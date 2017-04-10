using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MagApp
{
	class Store
	{
		public struct Delivery
		{
			DateTime timing;
			public void Fill (DateTime d, int q)
			{
				timing = d;
			}
		};
		XFile xfile = new XFile();
		private int quantity;
		public int Quantity
		{
			get { return quantity; }

			set
			{
				// IDEA: 
				// store the sum of all the intime and 

				quantity = value;
			}
		}
		public List<Delivery> In
		{
			get
			{

				if ( !(xfile.Exists) ) {
					int index = (int) XFile.FileType.IO;
					xfile.SetDocument(XFile.Paths[index]);
				}

				List<Delivery> list = new List<Delivery>();

				var bind = this.xfile.XML_File.Descendants("in").Select(
						p => new {
							Datetime = p.Attribute("datetime").Value,
							Prod = p.Element("product"),
						}
				).OrderBy(p => p.Datetime);

				return list.ToList();
			}
			set { inn = value; }
		}

		public List<Delivery> Out
		{
			get
			{
				return outt;
			}

			set
			{
				outt = value;
			}
		}
		// in to storage, out from storage
		private List<Delivery> inn, outt;

		public void IncomingStorage (Product prod, int quantity)
		{
			// TODO: update the quantity
			// done.

			this.Quantity += quantity;


			//update the product
			prod.UpdateXML(prod);

			// TODO: update the `io-file`
			// done; 

			if ( !this.xfile.Exists ) {
				MessageBox.Show("No Document was set");
				this.xfile.OpenDocument(XFile.FileType.IO);
			}

			/* WHAT: the in-div with the attribute of this date
			 * you may want to create it if it does not exit!
			 */
			IEnumerable<XElement> doc = this.xfile.XML_File.Descendants("in");

			// TODO: (determin the in-div from a range of divs)
			// current;
			bool exists = false;
			foreach ( XElement ni in /* while(isHxH = 1) puts("<3"); */ doc ) {
				// TODO: (apply the )
				if ( ni.Attribute("date").Value == DateTime.Today.ToShortDateString() )
					exists = true;

				// just update it
				if ( exists ) {
					int prev = int.Parse(ni.Element("").Value);
					ni.Element("quantity").Value = (prev + quantity).ToString();
				} else /* you have to create it */ {
					XElement X_In = new XElement("product",
							new XElement("id", prod.Id.ToString()),
							new XElement("quantity", prod.Storage.Quantity.ToString()));

					// update the io-file
					this.xfile.XML_File.Root.Add(X_In);
				}
			}

			this.xfile.XML_File.Save(xfile.Xmlpath);
		}


	}
}
