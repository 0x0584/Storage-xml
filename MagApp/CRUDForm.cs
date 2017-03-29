using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MagApp
{
    public partial class CRUDForm : Form
    {

        // TODO: this is a basic CRUD, the only problem is 
        // how to do it using xml
        //

        // TODO: Bind the Grid  
        // done.

        XDocument xmldoc;
        List<Product> products;

        List<CheckBox> checks; // yeaah!!
        List<NumericUpDown> nums;
        List<Label> labels;


        public void SetupMain()
        {
            checks = new List<CheckBox>();
            nums = new List<NumericUpDown>();
            labels = new List<Label>();

            foreach (var item in groupBox2.Controls)
            {
                if ((item is CheckBox)) checks.Add((CheckBox)item);
                else if (item is NumericUpDown) nums.Add((NumericUpDown)item);
                else if (item is Label) labels.Add((Label)item);
            }

            foreach (var item in groupBox3.Controls)
            {
                if ((item is CheckBox)) checks.Add((CheckBox)item);
                else if (item is NumericUpDown) nums.Add((NumericUpDown)item);
                else if (item is Label) labels.Add((Label)item);
            }
        }

        public CRUDForm()
        {
            InitializeComponent();
            products = new List<Product>();

            // setup the texts
            comboBox3.Text = comboBox3.Items[0].ToString();
            numconcen.Value = 10;
            combcategory.Text = combcategory.Items[0].ToString();

            SetupMain();

        }

        //Product p = new Product(int.Parse(numconcen.Value.ToString()),
        //           int.Parse(comboBox3.Text), combcategory.Text,
        //            "foo", 50.15f);

        Product p;

        private void Parsexml(List<Product> prods, DataGridView datagrid)
        {
            Product.SetDocument(@"..\DATA\10_02_2017.xml");
            xmldoc = XDocument.Load(@"..\DATA\10_02_2017.xml");   //add xml document  

            var bind = xmldoc.Descendants("product").Select(p => new
            {
                Id = p.Element("id").Value,
                Lable = p.Element("lable").Value,
                Price = p.Element("price").Value,
                Quantity = p.Element("quantity").Value
            }
            ).OrderBy(p => p.Id);

            p = new Product(45, 33, "Whiskey", "Red Label", 10, 70.56f);

            // fill the data
            foreach (var item in bind)
                prods.Add(new Product(int.Parse(numconcen.Value.ToString()),
                    int.Parse(comboBox3.Text), combcategory.Text,
                    item.Lable, int.Parse(item.Quantity), float.Parse(item.Price)));



            for (int i = 0; i < prods.Count; i++)
            {
                try
                {
                    checks[i].Text = prods[i].Lable;
                    labels[i].Text = prods[i].Quantity.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show(string.Format("{0} this should be the next page", i));
                }
            }
            //bind the grid
            datagrid.DataSource = bind.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Parsexml(products, dgv);
        }

        #region CRUD operations
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            Product fooprod = new Product(int.Parse(numconcen.Value.ToString()),
                                int.Parse(comboBox3.Text), combcategory.Text,
                                tboxlable.Text, int.Parse(numericUpDown33.Value.ToString()),
                                float.Parse(tboxprice.Text));
            fooprod.XMLAdd(xmldoc);
            Parsexml(products, dgv);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {

            p.XMLRemove(xmldoc);
            Parsexml(products, dgv);
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            // TODO: change teh content of the datagrid
            // based on the new text.
            //

        }

    }
}
