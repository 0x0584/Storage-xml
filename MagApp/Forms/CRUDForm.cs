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
        // done.

        // TODO: Bind the Grid  
        // done.

        public CRUDForm()
        {
            InitializeComponent( );

            int index = (int) XFile.FileType.PRODUCTS;
            Product.XSource.SetDocument( XFile.Paths[ index ] );

        }

        private void Bind( DataGridView datagrid )
        {
            datagrid.DataSource = Product.List;
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            Bind( dgv );
        }

        #region CRUD operations
        private void btnadd_Click( object sender, EventArgs e )
        {
            FillForm m = new FillForm( );
            Product fooprod;

            m.ShowDialog( );

            if( !m.IsDisposed ) {
                fooprod = m.NewProduct( Product.GenerateID( ) );
                fooprod.AddXML( );
                m.Dispose( );
                m.Close( );
                Bind( dgv );
            }
        }

        private void btndelete_Click( object sender, EventArgs e )
        {
            // TODO: find the product based on the clicked cell. 
            // then, delete it form teh list and from the xml file.

            if( dgv.SelectedCells.Count > 0 ) {
                int scell = dgv.SelectedCells[ 0 ].RowIndex;
                DataGridViewRow drow = dgv.Rows[ scell ];

                foreach( Product item in Product.List )
                    if( int.Parse( drow.Cells[ 0 ].Value.ToString( ) ) == item.Id ) {
                        item.RemoveXML( );
                        Bind( dgv );
                        break;
                    }
            }
        }

        private void tbsearch_TextChanged( object sender, EventArgs e )
        {
            // TODO: change teh content of the datagrid
            // based on the new text.
            //

        }

        private void btnupdate_Click( object sender, EventArgs e )
        {
            // TODO take information from the datagrid
            // and send them to the Mainform.
            // then take the modified data and update 
            // the product
            //

            FillForm m = new FillForm( );
            ArrayList a = new ArrayList( );


            if( dgv.SelectedCells.Count > 0 ) {
                int scell = dgv.SelectedCells[ 0 ].RowIndex;
                DataGridViewRow drow = dgv.Rows[ scell ];
                foreach( DataGridViewCell item in drow.Cells )
                    a.Add( item );
            }

            int id = int.Parse( ((DataGridViewCell) a[ 0 ]).Value.ToString( ) ),
             quantity = int.Parse( ((DataGridViewCell) a[ 1 ]).Value.ToString( ) );
            float price = float.Parse( ((DataGridViewCell) a[ 3 ]).Value.ToString( ) );
            string lable = ((DataGridViewCell) a[ 2 ]).Value.ToString( ),
            volume = ((DataGridViewCell) a[ 4 ]).Value.ToString( ),
            type = ((DataGridViewCell) a[ 5 ]).Value.ToString( );

            /*
			 
			  int id = int.Parse(( (DataGridViewCell) a[0] ).Value.ToString()), 
        quantity = int.Parse(( (DataGridViewCell) a[2] ).Value.ToString()); 
      float price = float.Parse(( (DataGridViewCell) a[3] ).Value.ToString()); 
      string lable = ( (DataGridViewCell) a[1] ).Value.ToString(), 
      volume = ((DataGridViewCell) a[4] ).Value.ToString(), 
      type = ( (DataGridViewCell) a[5] ).Value.ToString();
			 */

            //MessageBox.Show(((DataGridViewCell)a[0]).Value.ToString()); 
            Product foo = new Product( id, volume, type, lable, quantity, price );


            //MessageBox.Show(((DataGridViewCell)a[0]).Value.ToString());

            m.UpdateProduct( foo );
            m.ShowDialog( );

            if( !m.IsDisposed ) {
                foreach( Product item in Product.List )
                    if( item.Id == id ) { item.UpdateXML( m.NewProduct( id ) ); break; }

                m.Dispose( );
                m.Close( );
                Bind( dgv );
            }
        }
        #endregion

        private void dgv_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            // TODO: find out how to do it!
            // done!

            if( dgv.SelectedCells.Count > 0 ) {
                int __rowindex = dgv.SelectedCells[ 0 ].RowIndex;
                DataGridViewRow drow = dgv.Rows[ __rowindex ];
                bool value;

                foreach( DataGridViewRow row in dgv.Rows ) {
                    int rowindex = row.Cells[ 0 ].RowIndex;
                    bool isit = (rowindex == __rowindex);

                    if( isit )
                        value = true;
                    else
                        value = false;

                    foreach( DataGridViewCell cell in row.Cells )
                        cell.Selected = value;
                }
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Dispose( );
            this.Close( );
        }

    }
}
