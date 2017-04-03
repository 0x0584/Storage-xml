using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;

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

        //public void SetupMain()
        //{
        //    checks = new List<CheckBox>();
        //    nums = new List<NumericUpDown>();
        //    labels = new List<Label>();

        //    foreach (var item in groupBox2.Controls)
        //    {
        //        if ((item is CheckBox)) checks.Add((CheckBox)item);
        //        else if (item is NumericUpDown) nums.Add((NumericUpDown)item);
        //        else if (item is Label) labels.Add((Label)item);
        //    }

        //    foreach (var item in groupBox3.Controls)
        //    {
        //        if ((item is CheckBox)) checks.Add((CheckBox)item);
        //        else if (item is NumericUpDown) nums.Add((NumericUpDown)item);
        //        else if (item is Label) labels.Add((Label)item);
        //    }
        //}

        public CRUDForm()
        {
            InitializeComponent();
            products = new List<Product>();
            Product.SetDocument(@"..\DATA\10_02_2017.xml");

            // setup the texts
            //comboBox3.Text = comboBox3.Items[0].ToString();
            //numconcen.Value = 10;
            //combcategory.Text = combcategory.Items[0].ToString();

            //SetupMain();

        }

        Product p;

        private void Parsexml(List<Product> prods, DataGridView datagrid)
        {
            xmldoc = XDocument.Load(@"..\DATA\10_02_2017.xml");   //add xml document  

            var bind = xmldoc.Descendants("product").Select(p => new
            {
                Id = p.Element("id").Value,
                Lable = p.Element("lable").Value,
                Price = p.Element("price").Value,
                Volume = p.Element("volume").Value,
                Type = p.Element("type").Value,
                Quantity = p.Element("quantity").Value
            }
            ).OrderBy(p => p.Id);

            prods.Clear();

            // fill the list of products
            foreach (var item in bind)
            {
                Product foo = new Product(int.Parse(item.Id), item.Volume,
                    item.Type, item.Lable, int.Parse(item.Quantity),
                    float.Parse(item.Price));

                prods.Add(foo);
            }

            //bind the grid
            datagrid.DataSource = bind.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Parsexml(products, dgv);
            p = new Product("test", "foo", "foo", 10, 15.12f);
        }

        #region CRUD operations
        private void btnadd_Click(object sender, EventArgs e)
        {
            FillForm m = new FillForm();
            Product fooprod;

            m.ShowDialog();

            if (!m.IsDisposed)
            {
                fooprod = m.NewProduct(Product.GenerateID());
                fooprod.XMLAdd();
                m.Dispose();
                m.Close();
                Parsexml(products, dgv);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // TODO: find the product based on the clicked cell. 
            // then, delete it form teh list and from the xml file.

            if (dgv.SelectedCells.Count > 0)
            {
                int scell = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow drow = dgv.Rows[scell];

                foreach (Product item in products)
                    if (int.Parse(drow.Cells[0].Value.ToString()) == item.Id)
                    {
                        item.XMLRemove();
                        products.Remove(item);
                        Parsexml(products, dgv);
                        break;
                    }
            }
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            // TODO: change teh content of the datagrid
            // based on the new text.
            //

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // TODO take information from the datagrid
            // and send them to the Mainform.
            // then take the modified data and update 
            // the product
            //

            FillForm m = new FillForm();
            ArrayList a = new ArrayList();


            if (dgv.SelectedCells.Count > 0)
            {
                int scell = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow drow = dgv.Rows[scell];
                foreach (DataGridViewCell item in drow.Cells)
                    a.Add(item);
            }


            int id = int.Parse(((DataGridViewCell)a[0]).Value.ToString());

            //MessageBox.Show(((DataGridViewCell)a[0]).Value.ToString());

            m.UpdateProduct(((DataGridViewCell)a[1]).Value.ToString(), // lable 
                            float.Parse(((DataGridViewCell)a[2]).Value.ToString()),  // price
                            ((DataGridViewCell)a[3]).Value.ToString(), // volume
                            ((DataGridViewCell)a[4]).Value.ToString(), // type
                            int.Parse(((DataGridViewCell)a[5]).Value.ToString()));   // quantity
            m.ShowDialog();

            if (!m.IsDisposed)
            {
                foreach (Product item in products)
                    if (item.Id == id)
                    { item.XMLUpdate(m.NewProduct(id)); break; }

                m.Dispose();
                m.Close();
                Parsexml(products, dgv);
            }
        }
        #endregion

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: find ou how to do it!
            //

            if (dgv.SelectedCells.Count > 0)
            {
                int __rowindex = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow drow = dgv.Rows[__rowindex];
                bool value;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int rowindex = row.Cells[0].RowIndex;
                    bool isit = (rowindex == __rowindex);

                    if (isit) value = true;
                    else value = false;

                    foreach (DataGridViewCell cell in row.Cells)
                        cell.Selected = value;
                }
            }
        }
    }
}
