using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagApp
{
    public partial class StorageForm : Form
    {
        List<Product> products;

        public StorageForm()
        {
            InitializeComponent();
            products = (List<Product>) Product.List;

            foreach (Product prod in products)
            {

            }
        }

        private void btnaddtolist_Click(object sender, EventArgs e)
        {

        }

    }
}
