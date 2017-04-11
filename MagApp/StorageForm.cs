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

		public StorageForm ()
		{
			InitializeComponent();

			foreach ( Product prod in Product.List )
				combproducts.Items.Add(prod.Lable);

			current = new Product();

			combproducts.Text = combproducts.Items[0].ToString();

			// HERE: show the list of in product of today and add a button 
			// to swap between the past and previous ins 
			dgvstorage.DataSource = current.Storage.In;
		}

		private void btnaddtolist_Click (object sender, EventArgs e)
		{
			// TODO: fix the add in the list
			//


			string newstring = "";

			/* WHAT: whether the product is already in the list */
			int i = 0;
			bool exists = false;
			foreach ( string item in listadded.Items ) {


				string[] str = item.ToString().Split(new char[2] { '(', ')' });
				string lable = str[0].TrimEnd();
				decimal newvalue = 0;
				bool isequale = string.Equals(current.Lable, lable);


				if ( isequale ) {
					// add the new and the previous values
					newvalue = numquantity.Value + int.Parse(str[1]);
					// update the list item overview
					newstring = FormatLabel(current.Lable, ( numquantity.Value = newvalue ));
					// flag it's existance
					exists = true;
					break;
				}
				++i;
			}

			if ( !exists ) {
				// setup a fresh item
				listadded.Items.Add(FormatLabel(current.Lable, numquantity.Value));
				// select the item
				listadded.SetSelected(listadded.Items.Count - 1, true);
			} else {
				// it exists!
				// you may want to check this `i`
				listadded.Items[i] = newstring;
				listadded.SetSelected(i, true);
			}

		}

		private string FormatLabel (string lable, decimal quantity)
		{
			return string.Format("{0} ({1})", lable, quantity);
		}

		private void btnremove_Click (object sender, EventArgs e)
		{
			if ( listadded.SelectedItem != null ) {
				int index = listadded.SelectedIndex;
				string[] str = listadded.Items[index].ToString().Split(new char[] { '(', ')' });

				// the total taht is stored in teh label
				float total = int.Parse(labltotal.Text.Split(new char[] { ' ' })[0]),
				price = 0.0f;

				foreach ( Product prod in Product.List )
					if ( string.Equals(prod.Lable, str[0]) )
						price = prod.Price;

				// minus teh price of the removed items
				total -= ( float.Parse(str[1]) * price );

				labltotal.Text = total.ToString();
				listadded.Items.Remove(listadded.Items[index]);
			} else { labnotif.Text = "Select a product first"; }
		}

		private void btnconfirm_Click (object sender, EventArgs e)
		{
			// TODO: bind the datagrid and update the XML file
			//

			// get the current list of incomming storage
			List<Product> current = new List<Product>();

			foreach ( string item in listadded.Items ) {
				string[] str = item.Split(new char[] { '(', ')' });
				// List all the products
				foreach ( Product prod in Product.List )
					if ( prod.Lable == str[0].TrimEnd() ) {
						current.Add(prod);
						prod.Storage.IncomingStorage(prod, int.Parse(str[1].TrimEnd()));
					}
			}

			// bind the datagridview
			dgvstorage.DataSource = current.ToList();



		}

		private void listadded_SelectedIndexChanged (object sender, EventArgs e)
		{
			labnotif.Text = "";

			if ( listadded.SelectedItem != null ) {
				string[] info = listadded.SelectedItem.ToString().Split(new char[2] { '(', ')' });

				combproducts.Text = info[0];
				numquantity.Value = int.Parse(info[1]);

				float total = 0;

				// TODO: find how to take few digits from 
				// the foalt number
				// 

				foreach ( string item in listadded.Items ) {
					string[] str = item.ToString().Split(new char[2] { '(', ')' });

					if ( string.Equals(str[0].Substring(0, str[0].Length - 1), current.Lable) ) {
						total += ( float.Parse(str[1]) * current.Price );
						break;
					}
				}

				labltotal.Text = string.Format("{0:0.00} MAD", total.ToString());
			}

		}

		private void combproducts_SelectedIndexChanged (object sender, EventArgs e)
		{
			// TODO: update the quantity lable
			// done.

			string labcurrent = combproducts.Text;

			foreach ( Product prod in Product.List )
				if ( prod.Lable == labcurrent ) {
					prod.CopyTo(current);
					lablquant.Text = string.Format("({0})", current.Storage.Quantity);

					for ( int index = 0; index < listadded.Items.Count; ++index ) {
						string[] str = ( (string) listadded.Items[index] ).Split(new char[] { '(', ')' });
						bool isit = ( str[0].TrimEnd() == labcurrent ) ? true : false;

						listadded.SetSelected(index, isit);
						/* you need a */ break; /* you need KitKat*/ 
						// rempplace all the foreach-loops witha  standard forloop
					}
					break; // we found it!
				}

		}

		private void combproducts_TextUpdate (object sender, EventArgs e)
		{


			string labcurrent = combproducts.SelectedItem.ToString();

			foreach ( Product prod in Product.List )
				if ( prod.Lable == labcurrent ) { prod.CopyTo(current); break; }

			lablquant.Text = string.Format("({0})", current.Storage.Quantity);
		}
	}
}

