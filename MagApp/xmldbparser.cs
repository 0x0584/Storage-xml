using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace xmldbparser
{
    public class XMLog
    {
        // XML text-file
        private XmlTextWriter xtw;
        // XML document
        private XDocument xdoc;
        
        // XML nodes
        private XmlNodeList list;
        // XML settings
        private XmlWriterSettings settings;

        enum Tags
        {
            DATABASE = 0, FILE, PRODUCTS,
            PRODUCT, LABLE, QUANTITY,
            IN, OUT, TIMING,

            TAGS_COUNT
        };

        string[] tags;
        private string address;

        public string filename
        {
            get
            {
                DateTime foo = DateTime.Today;
                return string.Format("{0}_{1}_{2}.xml", foo.Day, foo.Month, foo.Year);
            }
            set { }
        }

        public XMLog(string path)
        {
            #region init expected attributes
            tags = new string[(int)Tags.TAGS_COUNT] {
                 "database", "file", "products",
                 "product", "lable", "quantity",
                 "in", "out", "timing"};
            #endregion
            #region init xml document and its settings
            xdoc = XDocument.Load(path);
            settings = new XmlWriterSettings();
            settings.Indent = true;
            #endregion

            // Save the document to a file and auto-indent the output.
            xdoc.Save(XmlWriter.Create(filename, settings));

            //xdoc.Load(file);  
            
        }

        public void ReadXML()
        {

            //list = xdoc.GetElementsByTagName(tags[(int)Tags.PRODUCTS]);

            //// loop through the nodes 
            //for (int i = 0; i < list.Count; i++)
            //{
            //    // xml elements
            //    // store the i-th `Customer` node
            //    XmlElement product = (XmlElement)xdoc.GetElementsByTagName(tags[(int)Tags.PRODUCT])[i];
            //    // store the i-th `Address` node
            //    XmlElement label = (XmlElement)xdoc.GetElementsByTagName(tags[(int)Tags.LABLE])[i];

            //    MessageBox.Show(string.Format("{0} - {0}", product.GetAttribute("id"), label.GetAttribute("id")));

            //    // testing the value of the attribute `Name`
            //    if ((product.GetAttribute("id")) == "ID")
            //    {
            //        // retrieve the content of the address
            //        MessageBox.Show(product.GetAttribute("id"));
            //        break;
            //    }
            //}

            var products = xdoc.Descendants("product");

            foreach (var p in products)
            {
                //    MessageBox.Show(p.Value.ToString());
                //    MessageBox.Show(p.GetDefaultNamespace().ToString());
                MessageBox.Show(p.Attribute("id").Value.ToString());
            }
        }

        public void WriteXML()
        {
            //// create an `customer` xml node
            //XmlElement cl = xdoc.CreateElement("Customer");
            //// set the attribute and its value
            //cl.SetAttribute("Name", "abc");
            //// create `address` xml node
            //XmlElement na = xdoc.CreateElement("Address");
            //// create an address node-content
            //XmlText natext = xdoc.CreateTextNode("xyz,india");
            //// append the content to the node
            //na.AppendChild(natext);
            //// append address to ndoe customer
            //cl.AppendChild(na);
            //// append the customer-node into teh document
            //xdoc.DocumentElement.AppendChild(cl);
            ////save the modified xml file into the disk
            //xdoc.Save(filename);
        }

        //public void updatexml()
        //{
        //    // our xml document
        //    XmlDocument xdoc = new XmlDocument();
        //    // open the xml file in a filestream
        //    FileStream up = new FileStream(filepath, FileMode.Open);
        //    // load the file
        //    xdoc.Load(up);
        //    // get a list of `Customer` nodes 
        //    XmlNodeList list = xdoc.GetElementsByTagName("Customer");
        //    // loop through the nodes
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        // get the i-th customer node
        //        XmlElement cu = (XmlElement)xdoc.GetElementsByTagName("Customer")[i];
        //        // get the i-th address node
        //        XmlElement add = (XmlElement)xdoc.GetElementsByTagName("Address")[i];
        //        // test on the `Name` attribute
        //        if (cu.GetAttribute("Name") == "abc")
        //        {
        //            // update the name attribute
        //            cu.SetAttribute("Name", "efgh");
        //            // update the address
        //            add.InnerText = "pqrs,india";
        //            break;
        //        }
        //    }
        //    // close the file stream
        //    up.Close();
        //    // save the modified xml file
        //    xdoc.Save(filepath);
        //}

        //public void removexml()
        //{
        //    // open the xml file in a filestream
        //    FileStream rfile = new FileStream(filepath, FileMode.Open);
        //    // the xml document
        //    XmlDocument tdoc = new XmlDocument();
        //    // load te document
        //    tdoc.Load(rfile);
        //    // list of `Customer` nodes
        //    XmlNodeList list = tdoc.GetElementsByTagName("Customer");
        //    // loop through the nodes
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        // get the i-th customer node
        //        XmlElement cl = (XmlElement)tdoc.GetElementsByTagName("Customer")[i];
        //        // test on the `Name` attribute
        //        if (cl.GetAttribute("Name") == "efgh")
        //        {
        //            tdoc.DocumentElement.RemoveChild(cl);
        //        }
        //    } // close the filestream
        //    rfile.Close();
        //    // save the modified xml file
        //    tdoc.Save(filepath);
        //}
    }
}