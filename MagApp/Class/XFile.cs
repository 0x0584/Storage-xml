using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
namespace MagApp
{
	public class XFile
	{
		public enum FileType { IO = 0, PRODUCTS = 1, FILE_COUNT };

		private string xmlpath;
		private XDocument xml;
		private static string[] paths = new string[] { @"..\DATA\IO.xml", @"..\DATA\10_02_2017.xml" };
		private bool exists;

		#region Propreties
		public static string[] Paths
		{
			get
			{
				return paths;
			}
		}
		public bool Exists
		{
			get
			{
				return exists;
			}

			set
			{
				this.exists = value;
			}
		}
		public XDocument XML_File
		{
			get
			{
				return xml;
			}

			set
			{
				this.xml = value;
			}
		}

		public string Xmlpath
		{
			get
			{
				return xmlpath;
			}

			set
			{
				this.xmlpath = value;
			}
		}
		#endregion

		public XFile () {
			exists = false;
			xml = null;
			xmlpath = "";
		}

		public XFile (string path)
		{

		}

		#region Document Setup
		public bool SetDocument (string fpath)
		{

			//// @"..\DATA\10_02_2017.xml"
			//string fooid = file.xdoc.Descendants("id").LastOrDefault().Value.ToString();
			//lastid = int.Parse(fooid);

			try {
				xml = XDocument.Load(fpath);
				xmlpath=	fpath;
				return exists = true;
			} catch ( Exception ) {
				MessageBox.Show("ERROR, WHILE LOADING FILE!");
				return exists = false;
			}
		}

		//public static bool SetDocument (ref XDocument xml, ref bool exists, string fpath)
		//{

		//	//// @"..\DATA\10_02_2017.xml"
		//	//string fooid = file.xdoc.Descendants("id").LastOrDefault().Value.ToString();
		//	//lastid = int.Parse(fooid);

		//	try {
		//		xml = XDocument.Load(fpath);
		//		xmlpath = fpath;
		//		return exists = true;
		//	} catch ( Exception ) {
		//		MessageBox.Show("ERROR, WHILE LOADING FILE!");
		//		return exists;
		//	}
		//}

		public void OpenDocument (FileType ftype)
		{
			OpenFileDialog op = new OpenFileDialog();
			string title = "";

			#region Setup the dialog

			switch ( ftype ) {
				case XFile.FileType.IO:
					title = "IO";
					break;
				case XFile.FileType.PRODUCTS:
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
				if ( !SetDocument(op.FileName))
					goto BEGIN;
		}
		#endregion




	}
}
