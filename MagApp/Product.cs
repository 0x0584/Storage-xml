using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
namespace MagApp
{
    public class Product
    {
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
        // TODO: just a normal id
        // done.
        private int id;
        static int lastid; // this id is the product of the last id

        private string lable;
        private int quantity;
        private float price;
        private string volume;
        private string type;
        private XElement XElem;
        static File file = null;
        static bool isthereafile;
        private List<Delivry> In, Out;

        #region Props
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Lable
        {
            get
            {
                return lable;
            }

            set
            {
                lable = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                // IDEA: 
                // store the sum of all the intime and 

                quantity = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        //public static string Filepath
        //{
        //    get
        //    {
        //        return @"..\DATA\10_02_2017.xml";
        //    }

        //    set { file.filepath = @"..\DATA\10_02_2017.xml"; }
        //}
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

        public static int GenerateID()
        {
            return ++lastid;
        }

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

            XElem = file.xdoc.Descendants("product").FirstOrDefault(
                p => p.Element("id").Value == id.ToString()
                );
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

        #region XML Operation
        public void XMLAdd()
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

        public void XMLRemove()
        {
            // TODO: remove from XML
            // done

            XElement product = file.xdoc.Descendants("product").FirstOrDefault(
                p => p.Element("id").Value == id.ToString()
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

        public void XMLUpdate(Product prod)
        {
            // TODO: update an existing product
            // UPDATE: NOT YET!
            // 

            //XElement XProduct = x.Descendants("product").FirstOrDefault(
            //    p => p.Element("id").Value == id.ToString()
            //);

            XElement XProduct = file.xdoc.Descendants("product").FirstOrDefault(
                p => int.Parse(p.Element("id").Value) == id);
            
            //List<XElement> list = file.xdoc.Descendants("product").ToList();

            //XElement x;
            //foreach (XElement item in list)
            //{
            //    if (int.Parse(item.Element("id").Value) == id)
            //        x = item;
            //}

            // HERE
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

        public override string ToString()
        {
            return string.Format("(ID: {0}) {1} - {2} DH", id, lable.ToUpper(), price);
        }
    }
}
