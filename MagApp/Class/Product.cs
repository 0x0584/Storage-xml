using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Globalization;
using Core.Xml;

namespace Core.Class
{
#pragma warning disable CS0659
    public class Product
#pragma warning restore CS0659
    {
        #region Local variables
        private int id;
        private string lable;

        private float uprice;
        private string volume;
        private string type;
        private Store storage;
        #endregion

        #region Static variables
        private static float C = 1.05F; // UNIT PRICE x C = PRICE 
        private static int lastid; // this id is the id of the last product
        private static XFile xfile = new XFile( );
        private static int min = 20; // minimum quantity before warning
        #endregion

        #region Properties

        public int Id {
            get { return id; }

            set { id = value; }
        }

        public int Quantity {
            get { return storage.Quantity; }
        }

        public string Lable {
            get { return lable; }

            set { lable = value; }
        }

        public float Price {
            get { return float.Parse( string.Format( "{0:0000.00}", (C * uprice) ) ); }
        }

        public float Unit_Price {
            get { return uprice; }

            set { uprice = float.Parse( string.Format( "{0:0000.00}", (value) ) ); }
        }

        public string Volume {
            get { return volume; }

            set { volume = value; }
        }

        public string Type {
            get { return type; }

            set { type = value; }
        }

        public static List<Product> List {
            get
            {
                #region Check source
                if( !(XSource == null) ) {
                    int index = (int) XFile.FileType.PRODUCTS;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
                if( !(xfile.Exists) ) {
                    MessageBox.Show( "No Document was set" );
                    xfile.OpenDocument( XFile.FileType.PRODUCTS );
                }
                #endregion

                List<Product> list = new List<Product>( );

                #region Setup list
                var bind = xfile.XML_File.Descendants( "product" ).Select( p => new {
                    ProductID = p.Element( "id" ).Value,
                    Lable = p.Element( "lable" ).Value,
                    Price = p.Element( "price" ).Value,
                    Volume = p.Element( "volume" ).Value,
                    Type = p.Element( "type" ).Value,
                    Quantity = p.Element( "quantity" ).Value
                }
                ).OrderBy( p => p.ProductID );

                // fill the list of products
                foreach( var item in bind ) {
                    // stack-it
                    Product foo = new Product( int.Parse( item.ProductID ), item.Volume,
                            item.Type, item.Lable, int.Parse( item.Quantity ),
                            float.Parse( item.Price ) );
                    list.Add( foo );
                }
                #endregion

                return list;
            }
        }

        public static XFile XSource {
            get
            {
                return xfile;
            }
            set
            {
                int index = (int) XFile.FileType.PRODUCTS;
                if( !Product.XSource.SetDocument( XFile.Paths[ index ] ) )
                    MessageBox.Show( "FILE NOT FOUND" );

            }
        }

        internal Store Storage {
            get
            {
                return storage;
            }

            set
            {
                this.storage = value;
            }
        }

        public bool IsLessThanMin { get { return (Quantity < MinQuantity); } }

        public static int MinQuantity { get { return min; } }
        #endregion

        #region Methods
        #region Static Methods
        public static int GenerateID()
        { // recover lastID  
          // done. 

            var listid = xfile.XML_File.Descendants( "id" ).ToList( );

            if( listid.Count != 0 ) {
                lastid = int.Parse( listid[ 0 ].Value );

                foreach( var item in listid )
                    if( int.Parse( item.Value ) >= lastid )
                        lastid = int.Parse( item.Value );

            } else lastid = 0;

            return ++lastid;
        }
        public static Product Parse( int id )
        {
            Product foo = new Product( );

            foreach( Product item in List )
                if( id == item.Id ) {
                    return item;
                }

            // not found!
            return null;
        }

        #endregion

        public void CopyTo( Product to )
        {
            to.Id = id;
            to.Lable = lable;
            to.Type = type;
            to.Volume = volume;
            to.Storage.Quantity = storage.Quantity;
            to.Unit_Price = uprice;

            //  to.Storage.In = storage.In;
            // to.Storage.Out = storage.Out;
        }
        #endregion

        #region Constructors
        public Product()
        {
            // setup the document if the methode `SetDocument`
            // was not called outside
            storage = new Store( );

            int fcount = (int) XFile.FileType.FILE_COUNT;
            for( int i = 0; i < fcount; i++ )

                if( xfile.Exists ) {
                    int index = (int) XFile.FileType.PRODUCTS;
                    xfile.SetDocument( XFile.Paths[ index ] );
                }
        }

        public Product( string volume, string type,
                string lable, int quantity, float price ) : base( )
        {
            // setup the document if the methode `SetDocument`
            // was not called outside

            storage = new Store( id = GenerateID( ) );
            this.lable = lable;
            this.uprice = price;
            this.volume = volume;
            this.type = type;
            storage.Quantity = quantity;
        }

        public Product( int id, string volume, string type,
                string lable, int quantity, float price ) : base( )
        {
            storage = new Store( (this.id = id) );
            this.lable = lable;
            this.uprice = price;
            this.volume = volume;
            this.type = type;
            storage.Quantity = quantity;
        }

        #endregion

        #region XML-CRUD Operation
        public void AddXML()
        {
            // TODO: add product to a XML file
            // done.

            XElement XProduct = new XElement( "product",
                    new XElement( "id", id.ToString( ) ),
                    new XElement( "lable", lable ),
                    new XElement( "type", type ),
                    new XElement( "price", uprice.ToString( ) ),
                    new XElement( "volume", volume ),
                    new XElement( "quantity", storage.Quantity.ToString( ) ) );

           

            #region Check source
            if( !(XSource == null) ) {
                int index = (int) XFile.FileType.PRODUCTS;
                xfile.SetDocument( XFile.Paths[ index ] );
            }
            if( !(xfile.Exists) ) {
                MessageBox.Show( "No Document was set" );
                xfile.OpenDocument( XFile.FileType.PRODUCTS );
            }
           
            #endregion

            xfile.XML_File.Root.Add( XProduct );
            xfile.XML_File.Save( xfile.Xmlpath );

           
        }

        public void RemoveXML()
        {
            // TODO: remove from XML
            // done

            #region Check source
            if( !(XSource == null) ) {
                int index = (int) XFile.FileType.PRODUCTS;
                xfile.SetDocument( XFile.Paths[ index ] );
            }
            if( !(xfile.Exists) ) {
                MessageBox.Show( "No Document was set" );
                xfile.OpenDocument( XFile.FileType.PRODUCTS );
            }
            #endregion

            XElement product = xfile.XML_File.Descendants( "product" ).FirstOrDefault(
                    p => int.Parse( p.Element( "id" ).Value ) == id );

            if( product != null ) {
                product.Remove( );

                xfile.XML_File.Save( xfile.Xmlpath );
            }
        }

        public void UpdateXML( Product prod )
        {
            // TODO: (create the file if it does not exists)
            // done;
            #region Check source
            if( !(XSource == null) ) {
                int index = (int) XFile.FileType.PRODUCTS;
                xfile.SetDocument( XFile.Paths[ index ] );
            }
            if( !(xfile.Exists) ) {
                MessageBox.Show( "No Document was set" );
                xfile.OpenDocument( XFile.FileType.PRODUCTS );
            }
            #endregion

            // TODO: (update an existing product)
            // done;
            XElement XProduct = xfile.XML_File.Descendants( "product" ).FirstOrDefault(
                    p => int.Parse( p.Element( "id" ).Value ) == id );

            if( XProduct != null ) { // test whether it exists-or-not
                XProduct.Element( "lable" ).Value = prod.lable;
                XProduct.Element( "type" ).Value = prod.type;
                XProduct.Element( "volume" ).Value = prod.volume;
                XProduct.Element( "price" ).Value = prod.uprice.ToString( );
                XProduct.Element( "quantity" ).Value = prod.storage.Quantity.ToString( );

                xfile.XML_File.Save( xfile.Xmlpath );
            } else
                MessageBox.Show( "NOT FOUND!" );
        }
        #endregion

        #region Overrided methods
        public override string ToString()
        {
            string str = string.Format( "[{4}] {0} {1} (x{2}) {3:00.00} MAD", id, lable, Storage.Quantity, uprice,IsLessThanMin ? "X":" " );

            return str;
        }

        public override bool Equals( object obj )
        {

            if( obj == null || GetType( ) != obj.GetType( ) ) {
                return false;
            }

            // TODO: write your implementation of Equals() here

            var _id = ((Product) obj).id;
            var _lable = ((Product) obj).lable;
            var _price = ((Product) obj).uprice;
            var _quant = ((Product) obj).storage.Quantity;
            var _type = ((Product) obj).type;
            var _volume = ((Product) obj).volume;

            if( _id == id && _lable == lable && _price == uprice &&
                        _quant == storage.Quantity && _type == type &&
                        _volume == volume )
                return true;
            else
                return false;
        }
        #endregion

    }
}
