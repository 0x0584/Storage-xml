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
        public Store()
        {
        }
        public Store( int id )
        {
            this.id = id;
        }


        private static XFile xfile = new XFile( );
        private int quantity;
        private int id;

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
        public List<Delivery> In {
            get
            {
                #region check source-file
                if( !( Product.Source == null ) ) {
                    int index = ( int ) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                #endregion

                List<Delivery> list = new List<Delivery>( );

                #region List setup
                var bind = xfile.XML_File.Descendants( "in" ).Select(
                        p => new {
                            Id = p.Element( "product" ).Element( "id" ).Value,
                            Date = p.Attribute( "date" ).Value,
                            InQuantity = p.Element( "product" ).Element( "quantity" ).Value
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
        }
        public List<Delivery> Out {
            get
            {
                #region check source-file
                if( !( Product.Source == null ) ) {
                    int index = ( int ) XFile.FileType.IO;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                #endregion

                List<Delivery> list = new List<Delivery>( );

                #region List setup
                var bind = xfile.XML_File.Descendants( "out" ).Select(
                    p => new {
                        Id = p.Element( "product" ).Element( "id" ).Value,
                        Date = p.Attribute( "date" ).Value,
                        InQuantity = p.Element( "product" ).Element( "quantity" ).Value
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
        }
        public static XFile Source {
            get { return xfile; }
            set
            {
                int index = ( int ) XFile.FileType.PRODUCTS;
                if( !Source.SetDocument( XFile.Paths[ index ] ) )
                    MessageBox.Show( "FILE NOT FOUND" );
            }
        }
        public static IEnumerable<Delivery> All_In {
            get
            {

                List<Delivery> list = new List<Delivery>( );

                foreach( Product prod in Product.List )
                    list.AddRange( prod.Storage.In );

                return list.ToList( );
            }
        }
        public static IEnumerable<Delivery> All_Out {
            get
            {
                List<Delivery> list = new List<Delivery>( );

                foreach( Product prod in Product.List )
                    list.AddRange( prod.Storage.Out );

                return list.ToList( );
            }
        }
        #endregion

        public void ComingStorage( Product prod, int quantity, bool type )
        {
            // TODO: update the quantity
            // done.

            string[ ] str = new string[ ] { "in", "out" };
            string currentstorage = str[ ( type ) ? 0 : 1 ];

            #region Update product quantity
            Quantity += quantity;

            //update the product
            prod.UpdateXML( prod );
            #endregion

            // TODO: update the `io-file`
            // not done yet!!  

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
                // TODO: (apply the )
                if( !storagexists && ni.Attribute( "date" ).Value == DateTime.Today.ToShortDateString( ) )
                    storagexists = true;

                if( storagexists ) /* just update it */
                    if( ni.Element("product").Element( "id" ).Value == prod.Id.ToString( ) ) {
                        int prev_q = int.Parse( ni.Element("product").Element( "quantity" ).Value );
                        ni.Element( "product" ).Element( "quantity" ).Value = ( prev_q + quantity ).ToString( );
                        break;
                    }
            }

            if( !storagexists ) /* you have to create it */ {
                XElement X = new XElement( currentstorage, new XAttribute( "date", DateTime.Today.ToShortDateString( ) ),
                    new XElement( "product",
                        new XElement( "id", prod.Id.ToString( ) ),
                        new XElement( "quantity", prod.Storage.Quantity.ToString( ) )
                        ) );

                // update the io-file
                xfile.XML_File.Root.Add( X );
            }

            // save changes to xfile
            xfile.XML_File.Save( xfile.Xmlpath );
        }


    }
}
