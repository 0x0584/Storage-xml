using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
namespace MagApp
{
    class Product
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

        // TODO: generate a an id like XYZ-4321 
        // the first character, in this example 'X', 
        // is used to indicate its (product) category.
        // while the second character 'Y' is used to
        // indicate its concentration, and the third
        // character 'Z' is used to indicate its volume.
        // the four digits, 1123 VIVA FIBONACCI, are used
        // to indocate its unique reference to it's lable
        // 
        // done.
        private string id;
        static int lastid; // this id is the product of the last id

        private string lable;
        private int quantity;
        private float price;
        static File file = null;
        private bool isthereafile = false;
        private List<Delivry> In, Out;

        #region Props
        public string Id
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

                lastid = int.Parse(fooid.Substring(fooid.Length - 4));
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

        private string GenerateID(int conc, int vol, string categ)
        {
            string str = categ.Substring(0, 3).ToUpper();
            str += conc.ToString();

            switch (vol)
            {
                case 33: str += "A"; break;
                case 50: str += "B"; break;
                case 75: str += "C"; break;
                case 100: str += "D"; break;
            };

            return string.Format("{0}-{1}", str, ++lastid);
        }

        public Product(int conc, int volume, string catg, string lable, int q, float price)
        {
            // setup the document if the methode `SetDocument`
            // was not called outside
            if (file == null) OpenDocument();

            id = GenerateID(conc, volume, catg);
            this.lable = lable;
            this.price = price;
            quantity = q;

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
        public void XMLAdd(XDocument x)
        {
            // TODO: add product to a XML file
            // done.

            XElement XProduct = new XElement("product",
                new XElement("id", id.ToString()),
                new XElement("lable", lable),
                new XElement("price", price.ToString()),
                new XElement("quantity", quantity.ToString()));
            x.Root.Add(XProduct);

            if (isthereafile) x.Save(file.filepath);
            else OpenDocument();
        }

        public void XMLRemove(XDocument x)
        {
            // TODO: remove from XML
            // done

            XElement product = x.Descendants("product").FirstOrDefault(p => p.Element("id").Value == id);
            if (product != null)
            {
                product.Remove();
                x.Save(file.filepath);
            }
        }

        public void XMLUpdate(XDocument x, string ID, string lable, float price, int quant)
        {
            // TODO: update an existing product
            // done

            XElement XProduct = x.Descendants("product").FirstOrDefault(p => p.Element("id").Value == ID);

            if (XProduct != null)
            {
                XProduct.Element("lable").Value = lable;
                XProduct.Element("price").Value = price.ToString();
                XProduct.Element("quantity").Value = quant.ToString();
                x.Root.Add(XProduct);
                x.Save(file.filepath);
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
