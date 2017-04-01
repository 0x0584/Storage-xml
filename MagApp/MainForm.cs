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
    public partial class MainForm : Form
    {
        private int qu;
        private string type, lab, v;
        private float pr;


        public MainForm()
        {
            InitializeComponent();

        }

        Product p;

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

        public void UpdateProduct(string lab, float p, string v, string type, int q)
        {
            combvol.Text = v;
            numquan.Value = q;
            combtype.Text = type;
            tboxlabel.Text = lab;
            tboxprice.Text = p.ToString();
        }
    }
}
