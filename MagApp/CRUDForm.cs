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
        //
         
        XDocument xmldoc;
        List<Product> products;

        public void BindGrid(DataGridView datagrid)
        {
            xmldoc = XDocument.Load(@"..\DATA\template.xml");   //add xml document  

            var bind = xmldoc.Descendants("product").Select(p => new
            {
                Id = p.Element("id").Value,
                Lable = p.Element("lable").Value,
                Quantity = p.Element("quantity").Value
            }
            ).OrderBy(p => p.Id);
            datagrid.DataSource = bind.ToList();
            
        }

        public CRUDForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BindGrid(dgv);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {


        }
    }
}
