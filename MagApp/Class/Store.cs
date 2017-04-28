using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
//
using Core.Xml;

namespace Core.Class
{
    class Store
    {
        public enum ListType
        {
            IN = 0,
            OUT,
            REST
        }

        #region Construtors
        public Store()
        {
        }
        public Store( int id )
        {
            this.id = id;
        }
        #endregion

        #region Local Variables
        private int quantity;
        private int id;
        #endregion

        #region Static Variables
        private static XFile xfile = new XFile( );
        #endregion

        #region Propreties
        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public IEnumerable<Delivery> In {
            get
            {
                #region check file existence
                if( !(XSource == null) ) {
                    int index = (int) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                if( !(xfile.Exists) ) {
                    MessageBox.Show( "No Document was set" );
                    xfile.OpenDocument( XFile.FileType.IO );
                }
                #endregion


                return GetStorage( "in" );
            }
        }

        // i just want to tell my self in the future that you diserve 
        // a better situation that this one! you have to go hard and keep trying
        // i know you want to do some low-level stuff ut for the moment, you have 
        // to finish this job! then; you can do whatever you want!

        public IEnumerable<Delivery> Out {
            get
            {
                #region check file existence
                if( !(XSource == null) ) {
                    int index = (int) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                if( !(xfile.Exists) ) {
                    MessageBox.Show( "No Document was set" );
                    xfile.OpenDocument( XFile.FileType.IO );
                }
                #endregion


                return GetStorage( "out" );
            }
        }

        public IEnumerable<Delivery> Rest {
            get
            {
                #region check file existence
                if( !(XSource == null) ) {
                    int index = (int) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                if( !(xfile.Exists) ) {
                    MessageBox.Show( "No Document was set" );
                    xfile.OpenDocument( XFile.FileType.IO );
                }
                #endregion

                return GetStorage( "rest" );
            }
            set { }
        }
        // TODO: here I should find a way to not show 
        // the date! just the products and thier quantity
        // done.
        #region Static Propreties
        public static IEnumerable<object> All_In {
            get
            {
                List<object> list = new List<object>( );

                foreach( Product prod in Product.List ) {
                    int q_sum = 0;
                    foreach( Delivery del in prod.Storage.In )
                        if( del.Id == prod.Id ) {
                            q_sum += del.Quantity;
                        }

                    list.Add( new { Product = prod.Lable, Quantity = q_sum } );
                }

                return list;
            }
        }

        public static IEnumerable<object> All_Out {
            get
            {
                List<object> list = new List<object>( );

                foreach( Product prod in Product.List )
                    foreach( Delivery del in prod.Storage.Out )
                        if( del.Id == prod.Id )
                            list.Add( new { Product = prod.Lable, Quantity = del.Quantity } );

                return list;
            }
        }

        public static XFile XSource {
            get { return xfile; }
            set
            {
                int index = (int) XFile.FileType.PRODUCTS;
                if( !XSource.SetDocument( XFile.Paths[ index ] ) )
                    MessageBox.Show( "FILE NOT FOUND" );
            }
        }
        #endregion
        #endregion

        #region Methods
        private IEnumerable<Delivery> GetStorage( string type )
        {
            List<Delivery> list = new List<Delivery>( );

            #region List setup
            var bind = xfile.XML_File.Descendants( type ).Select(
                p => new {
                    Id = p.Element( "product" ).Element( "id" ).Value,
                    InQuantity = p.Element( "product" ).Element( "quantity" ).Value,
                    Date = p.Attribute( "date" ).Value
                }
            ).OrderBy( p => p.Date );

            foreach( var item in bind ) {
                Delivery d = new Delivery( );
                DateTime date = DateTime.Parse( item.Date );
                int in_q = int.Parse( item.InQuantity );

                if( int.Parse( item.Id ) == id ) {
                    d.Fill( date, in_q );
                    d.Id = id;
                    quantity += in_q;
                    // add it to the list
                    list.Add( d );
                }

            }
            #endregion

            return list.ToList( );
        }

        public void ComingStorage( Product prod, int quantity, ListType type )
        {
            // TODO: update the quantity
            // done.

            // TODO: substract quantity when it's out!
            if( type == ListType.OUT ) quantity *= (-1);

            string[ ] str = new string[ ] { "in", "out", "rest" };
            string currentstorage = str[ (int) type ];

            #region Update product quantity
            if( type != ListType.REST ) Quantity += quantity;
            else Quantity = quantity;

            //update the product
            prod.UpdateXML( prod );
            #endregion

            // TODO: update the `io-file`
            // done! 

            #region check file existence
            if( !(XSource == null) ) {
                int index = (int) XFile.FileType.IO;
                xfile.SetDocument( XFile.Paths[ index ] );
            }
            if( !xfile.Exists ) {
                MessageBox.Show( "No Document was set" );
                xfile.OpenDocument( XFile.FileType.IO );
            }
            #endregion

            /* WHAT: the div with the attribute of this date
             * you may want to create it if it does not exit!
             */
            IEnumerable<XElement> doc = xfile.XML_File.Descendants( currentstorage );

            // TODO: (determin the in-div from a range of divs)
            // current;

            bool storagexists = false;
            bool elem_exists = false;
            foreach( XElement ni in /* while(isHxH = 1) puts("<3"); */ doc ) {
                // TODO: check for today's coming storage (in-or-out)
                if( !storagexists && ni.Attribute( "date" ).Value == DateTime.Today.ToShortDateString( ) )
                    storagexists = true;

                #region Update the element if exists
                if( storagexists ) /* just update it */
                    if( ni.Element( "product" ).Element( "id" ).Value == prod.Id.ToString( ) ) {
                        elem_exists = true;
                        int prev_q;

                        #region setup quantity
                        prev_q = int.Parse( ni.Element( "product" ).Element( "quantity" ).Value );
                        if( type != ListType.REST ) prev_q += quantity;
                        //else prev_q = quantity;
                        #endregion

                        if( type == ListType.REST ) {
                            
                            XElement X = new XElement( "out",
                                new XAttribute( "date", DateTime.Today.ToShortDateString( ) ),
                                new XElement( "product", new XElement( "id", prod.Id.ToString( ) ),
                                new XElement( "quantity",  quantity - prev_q ) ) //</product>
                            );

                            xfile.XML_File.Root.Add( X );
                        }
                        string val = (type == ListType.REST ? quantity : prev_q).ToString( );
                        ni.Element( "product" ).Element( "quantity" ).Value = val;
                        // JUST 
                        break;
                        // THE WALL
                    }
                #endregion
            }

            #region Create new element
            if( !(storagexists) || !(elem_exists) ) /* you have to create it */ {
                XElement X = new XElement( currentstorage,
                    new XAttribute( "date", DateTime.Today.ToShortDateString( ) ),
                    new XElement( "product", new XElement( "id", prod.Id.ToString( ) ),
                    new XElement( "quantity", quantity ) ) //</product>
                );

                // update the io-file
                xfile.XML_File.Root.Add( X );
            }
            #endregion



            // save changes to xfile
            xfile.XML_File.Save( xfile.Xmlpath );
        }

        public static IEnumerable<object> SetupList( ListType type, DateTimePicker dpicker )
        {
            List<object> list = new List<object>( );
            List<Delivery> tmp = new List<Delivery>( );

            foreach( Product prod in Product.List ) {
                switch( type ) {
                    default: break;
                    case ListType.IN: tmp = prod.Storage.In.ToList( ); break;
                    case ListType.OUT: tmp = prod.Storage.Out.ToList( ); break;
                    case ListType.REST: tmp = prod.Storage.Rest.ToList( ); break;
                }

                foreach( Delivery del in tmp ) {
                    string pickstr = dpicker.Value.ToShortDateString( ),
                            today = del.Date.ToShortDateString( );
                    if( del.Id == prod.Id && pickstr == today )
                        list.Add( new { Product = prod.Lable, Quantity = del.Quantity } );
                }
            }
            return list;
        }
        #endregion
    }
}
