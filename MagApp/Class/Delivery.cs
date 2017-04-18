using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagApp
{
    public class Delivery
    {

        private DateTime timing;
        private int quantity;
        int id;

        public DateTime Timing {
            get
            {
                return timing;
            }

            set
            {
                timing = value;
            }
        }

        public int Quantity {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int Id {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

      

        public void Fill( DateTime d, int q )
        {
            timing = d;
            quantity = q;
        }

    }
}
