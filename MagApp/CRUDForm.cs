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

        public CRUDForm()
        {
            InitializeComponent();
            products = new List<Product>();

        }

        private void Parsexml(List<Product> prods, DataGridView datagrid)
        {
            xmldoc = XDocument.Load(@"..\DATA\template.xml");   //add xml document  

            var bind = xmldoc.Descendants("product").Select(p => new
            {
                Id = p.Element("id").Value,
                Lable = p.Element("lable").Value,
                Price = p.Element("price").Value,
                Quantity = p.Element("quantity").Value
            }
            ).OrderBy(p => p.Id);

            foreach (var item in bind)
                prods.Add(new Product(item.Id, item.Lable, float.Parse(item.Price)));
            
            datagrid.DataSource = bind.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Parsexml(products, dgv);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Product p = new Product("1123", "foo", 50.15f);
            p.AddToXML(xmldoc);
        }
    }
}
