using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MagApp
{
	public class Product
	{
		#region Classes and Structures
		protected struct Delivery
		{
			DateTime timing;



			public void Fill (DateTime d, int q)
			{
				timing = d;

			}

		};

		public class File
		{
			public string filepath;
			public XDocument x;
			public enum FileType { IO = 0, PRODUCTS = 1, FILE_COUNT };
			public void SetFile (XDocument x, string fp)
			{
				filepath = fp;
				this.x = x;
			}
		};

		#endregion

		#region Local variables
		private int id;
		private string lable;
		private int quantity;
		private float price;
		private string volume;
		private string type;

		// in to storage, out from storage
		private List<Delivery> inn, outt;

		#region Static variables
		private static int lastid; // this id is the id of the last product
		public static File[] xdoc = new File[(int) File.FileType.FILE_COUNT] { null, null };
		public static bool[] isthereafile = new bool[(int) File.FileType.FILE_COUNT] { false, false };
		public static string[] paths = new string[] { @"..\DATA\IO.xml", @"..\DATA\10_02_2017.xml" };
		#endregion
		#endregion

		#region Properties

		public int Id
		{
			get { return id; }

			set { id = value; }
		}

		public string Lable
		{
			get { return lable; }

			set { lable = value; }
		}

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

		public float Price
		{
			get { return price; }

			set { price = value; }
		}

		public string Volume
		{
			get { return volume; }

			set { volume = value; }
		}

		public string Type
		{
			get { return type; }

			set { type = value; }
		}

		public static IEnumerable<Product> List
		{
			get
			{
				int index = (int) File.FileType.PRODUCTS;

				if ( !isthereafile[index] )
					SetDocument(ref xdoc[index], ref isthereafile[index], paths[index]);

				List<Product> list = new List<Product>();

				var bind = xdoc[index].x.Descendants("product").Select(p => new {
					ProductID = p.Element("id").Value,
					Lable = p.Element("lable").Value,
					Price = p.Element("price").Value,
					Volume = p.Element("volume").Value,
					Type = p.Element("type").Value,
					Quantity = p.Element("quantity").Value
				}
				).OrderBy(p => p.ProductID);

				// fill the list of products
				foreach ( var item in bind ) {
					Product foo = new Product(int.Parse(item.ProductID), item.Volume,
							item.Type, item.Lable, int.Parse(item.Quantity),
							float.Parse(item.Price));

					list.Add(foo);
				}

				return list.ToList();
			}
		}

		protected List<Delivery> In
		{
			get
			{
				int index = (int) File.FileType.IO;

				if ( !isthereafile[index] )
					SetDocument(ref xdoc[index], ref isthereafile[index], paths[index]);

				List<Delivery> list = new List<Delivery>();

				var bind = xdoc[index].x.Descendants("in").Select(
						p => new {
							Datetime = p.Attribute("datetime").Value,
							Prod = p.Element("product"),
						}
				).OrderBy(p => p.Datetime);

				return list.ToList();
			}
			set { inn = value; }
		}

		protected List<Delivery> Out
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

		#endregion

		#region Document Setup
		public static bool SetDocument (ref File file, ref bool flag, string fpath)
		{

			//// @"..\DATA\10_02_2017.xml"
			//string fooid = file.xdoc.Descendants("id").LastOrDefault().Value.ToString();
			//lastid = int.Parse(fooid);

			try {
				file = new File();
				file.SetFile(XDocument.Load(fpath), fpath);
				return ( flag = true );
			} catch ( Exception ) {
				MessageBox.Show("ERROR, WHILE LOADING FILE!");
				return ( flag = false );
			}
		}

		private void OpenDocument (File.FileType ftype)
		{
			OpenFileDialog op = new OpenFileDialog();
			string title = "";

			#region Setup the dialog

			switch ( ftype ) {
				case File.FileType.IO:
					title = "IO";
					break;
				case File.FileType.PRODUCTS:
					title = "PRODUCTS";
					break;
				default:
					title = "";
					break;
			};

			op.Title = title;
			op.FileName = string.Format("{0}.xml", DateTime.Today.ToString());

			op.DefaultExt = ".xml";
			op.Filter = "XML Document (.xml)|*.xml";
		#endregion

		BEGIN:
			MessageBox.Show(string.Format("No document is set for {0}", title));
			
			if ( op.ShowDialog() == DialogResult.OK )
				if ( !SetDocument(ref xdoc[(int) ftype], ref isthereafile[(int) ftype], op.FileName) )
					goto BEGIN;
		}
		#endregion

		#region Methods
		#region Static Methods
		public static int GenerateID ()
		{
			// recover lastID 
			// done.

			int index = (int) File.FileType.PRODUCTS;

			var listid = xdoc[index].x.Descendants("id").ToList();

			lastid = int.Parse(listid[0].Value);

			foreach ( var item in listid ) {
				if ( int.Parse(item.Value) >= lastid )
					lastid = int.Parse(item.Value);
			}

			return ++lastid;
		}
		#endregion

		public void CopyTo (Product to)
		{
			to.Id = id;
			to.Lable = lable;
			to.Type = type;
			to.Volume = volume;
			to.Quantity = quantity;
			to.Price = price;

			to.In = inn;
			to.Out = outt;
		}
		#endregion

		#region Constructors
		public Product ()
		{
			// setup the document if the methode `SetDocument`
			// was not called outside

			int fcount = (int) File.FileType.FILE_COUNT;

			for ( int i = 0; i < fcount; i++ ) 
				if ( xdoc[i] == null ) 
					SetDocument(ref xdoc[i], ref isthereafile[i], xdoc[i].filepath);
				
		}

		public Product (string volume, string type,
				string lable, int quantity, float price) : base()
		{
			// setup the document if the methode `SetDocument`
			// was not called outside

			id = GenerateID();
			this.lable = lable;
			this.price = price;
			this.quantity = quantity;
			this.volume = volume;
			this.type = type;

			//foreach (var i in intime)
			//    foreach (var ii in inquantity)
			//    {
			//        Delivry foo = new Delivry();
			//        foo.Fill(i, ii);

			//        In.Add(foo);
			//    }

			//foreach (var i in outime)
			//    foreach (var ii in outquantity)
			//    {
			//        Delivry foo = new Delivry();
			//        foo.Fill(i, ii);

			//        Out.Add(foo);
			//    }
		}

		public Product (int id, string volume, string type,
				string lable, int quantity, float price) : base()
		{
			this.id = id;
			this.lable = lable;
			this.price = price;
			this.quantity = quantity;
			this.volume = volume;
			this.type = type;
		}

		#endregion

		#region XML-CRUD Operation
		public void AddXML ()
		{
			// TODO: add product to a XML file
			// done.
			int index = (int)File.FileType.PRODUCTS;

			XElement XProduct = new XElement("product",
					new XElement("id", id.ToString()),
					new XElement("lable", lable),
					new XElement("type", type),
					new XElement("price", price.ToString()),
					new XElement("volume", volume),
					new XElement("quantity", quantity.ToString()));

			xdoc[index].x.Root.Add(XProduct);

			if ( !isthereafile[index] ) {
				MessageBox.Show("No Document was set");
				OpenDocument((File.FileType)index);
			}

			xdoc[index].x.Save(xdoc[index].filepath);
		}

		public void RemoveXML ()
		{
			// TODO: remove from XML
			// done

			int index = (int) File.FileType.PRODUCTS;

				if ( !isthereafile[index] ) {
					MessageBox.Show("No Document was set");
					OpenDocument((File.FileType) index);
				}

			XElement product = xdoc[index].x.Descendants("product").FirstOrDefault(
					p => int.Parse(p.Element("id").Value) == id );

			if ( product != null ) {
				product.Remove();

				xdoc[index].x.Save(xdoc[index].filepath);
			}
		}

		public void UpdateXML (Product prod)
		{
			// TODO: update an existing product
			// done.
			int index = (int) File.FileType.PRODUCTS;

			if ( !isthereafile[index] ) {
				MessageBox.Show("No Document was set");
				OpenDocument((File.FileType) index);
			}

			XElement XProduct = xdoc[index].x.Descendants("product").FirstOrDefault(
					p => int.Parse(p.Element("id").Value) == id);

			if ( XProduct != null ) {
				XProduct.Element("lable").Value = prod.lable;
				XProduct.Element("type").Value = prod.type;
				XProduct.Element("volume").Value = prod.volume;
				XProduct.Element("price").Value = prod.price.ToString();
				XProduct.Element("quantity").Value = prod.quantity.ToString();

				xdoc[index].x.Save(xdoc[index].filepath);
			} else MessageBox.Show("NOT FOUND!");
		}
		#endregion

		public void IncomingStorage (int quantity)
		{
			Product fooprod;

			this.quantity += quantity;
			fooprod = this;

			UpdateXML(fooprod);



		}

		#region Overrided methods
		public override string ToString ()
		{
			return string.Format("{0} {1} (x{2}) {3:00.00} MAD", id, lable, quantity, price);
		}

		public override bool Equals (object obj)
		{

			if ( obj == null || GetType() != obj.GetType() ) {
				return false;
			}

			// TODO: write your implementation of Equals() here

			var _id = ( (Product) obj ).id;
			var _lable = ( (Product) obj ).lable;
			var _price = ( (Product) obj ).price;
			var _quant = ( (Product) obj ).quantity;
			var _type = ( (Product) obj ).type;
			var _volume = ( (Product) obj ).volume;

			if ( _id == id &&
					_lable == lable &&
					_price == price &&
					_quant == quantity &&
					_type == type &&
					_volume == volume )
				return true;
			else
				return false;
		}
		#endregion
	}
}
