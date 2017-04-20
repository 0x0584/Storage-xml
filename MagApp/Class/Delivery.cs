using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagApp.Class
{
    public class Delivery
    {
        // TODO: remove the Fill method and use a constructor
        // panding..
        #region Local variables
        private DateTime date;
        private int quantity;
        private int id;
        #endregion

        #region Propreties
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
        public DateTime Date {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        #endregion

        #region Methods
        public void Fill( DateTime d, int q )
        {
            date = d;
            quantity = q;
        }
        #endregion

        public override string ToString()
        {
            string str = string.Format( "({1}) x({2}) : {0:dd/MM/yyyy}", date, id, quantity );
            return str;
        }
    }
}
