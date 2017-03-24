using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagApp
{
    class Product
    {
        private string id;
        private string lable;
        private int quantity;

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
        #endregion



        public Product(string id, string lable,
            List<DateTime> intime, List<DateTime> outime,
            List<int> inquantity, List<int> outquantity)
        {
            this.id = id;
            this.lable = lable;

            foreach (var i in intime)
                foreach (var ii in inquantity)
                {
                    Delivry foo = new Delivry();
                    foo.Fill(i, ii);

                    In.Add(foo);
                }

            foreach (var i in outime)
                foreach (var ii in outquantity)
                {
                    Delivry foo = new Delivry();
                    foo.Fill(i, ii);

                    Out.Add(foo);
                }
        }
    }
}
