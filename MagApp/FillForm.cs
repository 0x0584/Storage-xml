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
    public partial class FillForm : Form
    {
        private int qu;
        private string type, lab, v;
        private float pr;


        public FillForm()
        {
            InitializeComponent();

        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public Product NewProduct(int id)
        {
            v = combvol.Text;
            qu = int.Parse(numquan.Value.ToString());
            type = combtype.Text;
            lab = tboxlabel.Text;
            pr = float.Parse(tboxprice.Text);

            return new Product(id, v, type, lab, qu, pr);
        }

        public void UpdateProduct(Product prod)
        {
            combvol.Text = prod.Volume;
            numquan.Value = prod.Quantity;
            combtype.Text = prod.Type;
            tboxlabel.Text = prod.Lable;
            tboxprice.Text = prod.Price.ToString();
        }
    }
}
