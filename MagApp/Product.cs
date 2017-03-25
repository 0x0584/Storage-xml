using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace MagApp
{
    class Product
    {
        private string id;
        private string lable;
        private int quantity;
        private float price;
        private XDocument xdoc;
        struct Delivry
        {
            DateTime timing;
            int quantity;

            public void Fill(DateTime d, int q)
            {
                timing = d;
                quantity = q;
            }

        };

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
        #endregion



        public Product(string id, string lable, float price)
        {
            this.id = id;
            this.lable = lable;
            this.price = price;

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

        public void AddToXML(XDocument x)
        {
            XElement Product = new XElement("Product",
                new XElement("id", id.ToString()),
                new XElement("lable", lable),
                new XElement("price", price.ToString()),
                new XElement("quantity", quantity.ToString()));
            x.Root.Add(Product);
            System.Windows.Forms.MessageBox.Show(Product.ToString());
            x.Save(@"C:\Users\Anas Rchid\Documents\Visual Studio 2013\Projects\MagApp\MagApp\DATA\10_02_2017.xml");
        }

        public override string ToString()
        {
            return string.Format("({0}) {1} - {2} DH", id, lable.ToUpper(), price);
        }
    }
}
