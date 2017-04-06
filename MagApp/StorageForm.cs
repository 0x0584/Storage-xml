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

        Product current;

        public StorageForm()
        {
            InitializeComponent();

            foreach (Product prod in Product.List)
                combproducts.Items.Add(prod.Lable);

            current = new Product();

            combproducts.Text = combproducts.Items[0].ToString();
        }

        private void btnaddtolist_Click(object sender, EventArgs e)
        {
            // TODO: fix the add in the list
            //

            bool exists = false;
            decimal newvalue = 0;
            string newstring = "";
            int i = 0;

            foreach (string item in listadded.Items)
            {
                string[] str = item.ToString().Split(new char[2] { '(', ')' });

                if (string.Equals(current.Lable, str[0].Substring(0, str[0].Length - 1)))
                {
                    newvalue = numquantity.Value + int.Parse(str[1]);
                    newstring = string.Format("{0} ({1})", current.Lable, (numquantity.Value = newvalue));
                    exists = true; break;
                }
                ++i;
            }

            if (!exists)
            {
                listadded.Items.Add(string.Format("{0} ({1})", current.Lable, numquantity.Value));
                listadded.SetSelected(listadded.Items.Count - 1, true);
            }
            else
            {
                listadded.Items[i] = newstring;
                listadded.SetSelected(i, true);
            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listadded.SelectedItem != null)
            {
                int index = listadded.SelectedIndex;
                string[] str = listadded.Items[index].ToString().Split(new char[] { '(', ')' });

                // the total taht is stored in teh label
                float total = int.Parse(labltotal.Text.Split(new char[] { ' ' })[0]),
                price = 0.0f;

                foreach (Product prod in Product.List)
                    if (string.Equals(prod.Lable, str[0]))
                        price = prod.Price;

                // minus teh price of the removed items
                total -= (float.Parse(str[1]) * price);

                labltotal.Text = total.ToString();
                listadded.Items.Remove(listadded.Items[index]);
            }
            else { labnotif.Text = "Select a product first"; }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            // TODO: apply things to the dgv 
            //

            List<Product> current = new List<Product>();

            // List all the products
            foreach (Product prod in Product.List)
            {
                // 
                foreach (string item in listadded.Items)
                {
                    string[] str = item.Split(new char[] { '(', ')' });

                    if (prod.Lable == str[0].TrimEnd())
                    {
                        current.Add(prod);

                    }

                }
            }

            // TODO: apply things to the xml file 
            //


        }

        private void listadded_SelectedIndexChanged(object sender, EventArgs e)
        {
            labnotif.Text = "";

            if (listadded.SelectedItem != null)
            {
                string[] info = listadded.SelectedItem.ToString().Split(new char[2] { '(', ')' });

                combproducts.Text = info[0];
                numquantity.Value = int.Parse(info[1]);
            }

            float total = 0;

            // TODO: find how to take few digits from 
            // the foalt number
            // 

            foreach (string item in listadded.Items)
                foreach (Product prod in Product.List)
                {
                    string[] str = item.ToString().Split(new char[2] { '(', ')' });

                    if (string.Equals(str[0].Substring(0, str[0].Length - 1), prod.Lable))
                    {
                        total += (float.Parse(str[1]) * prod.Price);
                        break;
                    }
                }

            labltotal.Text = string.Format("{0:0.00} MAD", total.ToString());

        }

        private void combproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: update the quantity lable
            // done.

            string labcurrent = combproducts.SelectedItem.ToString();

            foreach (Product prod in Product.List)
                if (prod.Lable == labcurrent)
                { prod.CopyTo(current); break; }

            lablquant.Text = string.Format("({0})", current.Quantity);
        }
    }
}

