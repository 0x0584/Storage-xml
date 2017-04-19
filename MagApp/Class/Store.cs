using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MagApp
{
    class Store
    {
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
        #region Static Variables
        private static XFile xfile = new XFile( );
        #endregion
        #endregion

        #region Propreties
        public int Quantity {
            get { return quantity; }

            set
            {
                // IDEA: 
                // store the sum of all the intime and 

                quantity = value;
            }
        }
        public IEnumerable<Delivery> In {
            get
            {
                #region check source-file
                if( !(Product.XSource == null) ) {
                    int index = (int) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                #endregion

                return GetStorage( "in" );
            }
        }
        public IEnumerable<Delivery> Out {
            get
            {
                #region check source-file
                if( !(Product.XSource == null) ) {
                    int index = (int) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                #endregion

                return GetStorage( "out" );
            }
        }
        public static XFile Source {
            get { return xfile; }
            set
            {
                int index = (int) XFile.FileType.PRODUCTS;
                if( !Source.SetDocument( XFile.Paths[ index ] ) )
                    MessageBox.Show( "FILE NOT FOUND" );
            }
        }

        // TODO: here I should find a way to not show 
        // the date! just the products and thier quantity
        // done.
        public static IEnumerable<object> All_In {
            get
            {
                List<object> list = new List<object>( );

                foreach( Product prod in Product.List )
                    foreach( Delivery del in prod.Storage.In )
                        if( del.Id == prod.Id )
                            list.Add( new { Product = prod.Lable, Quantity = del.Quantity } );

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



        public void ComingStorage( Product prod, int quantity, bool isin )
        {
            // TODO: update the quantity
            // done.

            string[ ] str = new string[ ] { "in", "out" };
            string currentstorage = str[ (isin) ? 0 : 1 ];

            #region Update product quantity
            Quantity += quantity;

            //update the product
            prod.UpdateXML( prod );
            #endregion

            // TODO: update the `io-file`
            // done! 

            #region check file existence
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
            foreach( XElement ni in /* while(isHxH = 1) puts("<3"); */ doc ) {
                // TODO: check for today's coming storage (in-or-out)
                if( !storagexists && ni.Attribute( "date" ).Value == DateTime.Today.ToShortDateString( ) )
                    storagexists = true;

                #region Update the element if exists
                if( storagexists ) /* just update it */
                    if( ni.Element( "product" ).Element( "id" ).Value == prod.Id.ToString( ) ) {
                        int prev_q = int.Parse( ni.Element( "product" ).Element( "quantity" ).Value );
                        ni.Element( "product" ).Element( "quantity" ).Value = (prev_q + quantity).ToString( );
                        break;
                    }
                #endregion
            }

            #region Create new element
            if( !storagexists ) /* you have to create it */ {
                XElement X = new XElement( currentstorage, new XAttribute( "date", DateTime.Today.ToShortDateString( ) ),
                    new XElement( "product",
                        new XElement( "id", prod.Id.ToString( ) ),
                        new XElement( "quantity", prod.Storage.Quantity.ToString( ) )
                        ) );

                // update the io-file
                xfile.XML_File.Root.Add( X );
            }
            #endregion

            // save changes to xfile
            xfile.XML_File.Save( xfile.Xmlpath );
        }
        #endregion
    }
}
