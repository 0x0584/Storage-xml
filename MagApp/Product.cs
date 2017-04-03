using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MagApp
{
    public class Product
    {
        #region Classes and Structures
        protected struct Delivry
        {
            DateTime timing;
            int quantity;

            public void Fill(DateTime d, int q)
            {
                timing = d;
                quantity = q;
            }

        };

        protected class File
        {
            public string filepath;
            public XDocument xdoc;
            public void SetFile(XDocument x, string fp)
            {
                filepath = fp;
                xdoc = x;
            }
        };

        #endregion

        #region Local variables
        private int id;
        private static int lastid; // this id is the id of the last product
        private string lable;
        private int quantity;
        private float price;
        private string volume;
        private string type;

        // in to storage, out from storage
        private List<Delivry> In, Out;
        #region Static variables
        private static File file = null;
        private static bool isthereafile;
        #endregion
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public string Lable
        {
            get { return lable; }

            set { lable = value; }
        }

        public int Quantity
        {
            get { return quantity; }

            set
            {
                // IDEA: 
                // store the sum of all the intime and 

                quantity = value;
            }
        }

        public float Price
        {
            get { return price; }

            set { price = value; }
        }

        public string Volume
        {
            get { return volume; }

            set { volume = value; }
        }

        public string Type
        {
            get { return type; }

            set { type = value; }
        }

        public static List<Product> List
        {
            get
            {
                if (!isthereafile) SetDocument(@"..\DATA\10_02_2017.xml");

                List<Product> list = new List<Product>();

                var bind = file.xdoc.Descendants("product").Select(p => new
                {
                    Id = p.Element("id").Value,
                    Lable = p.Element("lable").Value,
                    Price = p.Element("price").Value,
                    Volume = p.Element("volume").Value,
                    Type = p.Element("type").Value,
                    Quantity = p.Element("quantity").Value
                }
                ).OrderBy(p => p.Id);

                // fill the list of products
                foreach (var item in bind)
                {
                    Product foo = new Product(int.Parse(item.Id), item.Volume,
                        item.Type, item.Lable, int.Parse(item.Quantity),
                        float.Parse(item.Price));

                    list.Add(foo);
                }

                return list.ToList();
            }
        } 
        #endregion

        #region Document Setup
        public static bool SetDocument(string filepath)
        {
            file = new File();
            // @"..\DATA\10_02_2017.xml"
            try
            {
                file.SetFile(XDocument.Load(filepath), filepath);
                string fooid = file.xdoc.Descendants("id").LastOrDefault().Value.ToString();
                lastid = int.Parse(fooid);
                isthereafile = true;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, WHILE LOADING FILE!");
                return false;
            }
        }

        private void OpenDocument()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = string.Format("{0}.xml", DateTime.Today.ToString());

            op.DefaultExt = ".xml";
            op.Filter = "XML Document (.xml)|*.xml";

            BEGIN:
            MessageBox.Show("No document is set");

            if (op.ShowDialog() == DialogResult.OK)
                if (SetDocument(op.FileName)) isthereafile = true;
                else goto BEGIN;
        }
        #endregion

        #region Static Methods
        public static int GenerateID()
        {
            return ++lastid;
        }

        #endregion

        #region Constructors
        public Product(int id, string volume, string type,
            string lable, int quantity, float price)
        {
            this.id = id;
            this.lable = lable;
            this.price = price;
            this.quantity = quantity;
            this.volume = volume;
            this.type = type;

            if (file == null) OpenDocument();
        }

        public Product(string volume, string type,
            string lable, int quantity, float price)
        {
            // setup the document if the methode `SetDocument`
            // was not called outside
            if (file == null) OpenDocument();

            id = GenerateID();
            this.lable = lable;
            this.price = price;
            this.quantity = quantity;
            this.volume = volume;
            this.type = type;

            //foreach (var i in intime)
            //    foreach (var ii in inquantity)
            //    {
            //        Delivry foo = new Delivry();
            //        foo.Fill(i, ii);

            //        In.Add(foo);
            //    }

            //foreach (var i in outime)
            //    foreach (var ii in outquantity)
            //    {
            //        Delivry foo = new Delivry();
            //        foo.Fill(i, ii);

            //        Out.Add(foo);
            //    }
        }
        #endregion

        #region XML Operation
        public void AddXML()
        {
            // TODO: add product to a XML file
            // done.

            XElement XProduct = new XElement("product",
                new XElement("id", id.ToString()),
                new XElement("lable", lable),
                new XElement("type", type),
                new XElement("price", price.ToString()),
                new XElement("volume", volume),
                new XElement("quantity", quantity.ToString()));

            file.xdoc.Root.Add(XProduct);

            if (!isthereafile)
            {
                MessageBox.Show("No Document was set");
                OpenDocument();
            }

            file.xdoc.Save(file.filepath);
        }

        public void RemoveXML()
        {
            // TODO: remove from XML
            // done

            XElement product = file.xdoc.Descendants("product").FirstOrDefault(
                p => int.Parse(p.Element("id").Value) == id
                );

            if (product != null)
            {
                product.Remove();

                if (!isthereafile)
                {
                    MessageBox.Show("No Document was set");
                    OpenDocument();
                }

                file.xdoc.Save(file.filepath);
            }
        }

        public void UpdateXML(Product prod)
        {
            // TODO: update an existing product
            // done.

            XElement XProduct = file.xdoc.Descendants("product").FirstOrDefault(
                p => int.Parse(p.Element("id").Value) == id);

            if (XProduct != null)
            {
                XProduct.Element("lable").Value = prod.lable;
                XProduct.Element("type").Value = prod.type;
                XProduct.Element("volume").Value = prod.volume;
                XProduct.Element("price").Value = prod.price.ToString();
                XProduct.Element("quantity").Value = prod.quantity.ToString();
                file.xdoc.Save(file.filepath);
            }
            else MessageBox.Show("NOT FOUND!");
        }
        #endregion

        #region Overrided methods
        public override string ToString()
        {
            return string.Format("(ID: {0}) {1} - {2} DH", id, lable.ToUpper(), price);
        }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here

            var _id = ((Product)obj).id;
            var _lable = ((Product)obj).lable;
            var _price = ((Product)obj).price;
            var _quant = ((Product)obj).quantity;
            var _type = ((Product)obj).type;
            var _volume = ((Product)obj).volume;

            if (_id == id &&
                _lable == lable &&
                _price == price &&
                _quant == quantity &&
                _type == type &&
                _volume == volume) return true;
            else return false;
        }
        #endregion
    }
}
