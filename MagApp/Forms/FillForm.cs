using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagApp.Class;

namespace MagApp.Forms
{
    public partial class FillForm : Form
    {
        private int qu;
        private string type, lab, v;
        private float pr;

        public int Quantity {
            get
            {
                return qu;
            }

            set
            {
                qu = value;
            }
        }

        public FillForm()
        {
            InitializeComponent( );

        }

        private void btnconf_Click( object sender, EventArgs e )
        {
            Hide( );
        }

        private void btnclose_Click( object sender, EventArgs e )
        {
            Dispose( );
            Close( );
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            combvol.Items.AddRange( new object[ ] { " 33  cl", " 50  cl", " 75  cl", "100 cl" } );
            combtype.Items.AddRange( new object[ ] { "WINE", "GIN", "WHISKEY", "VODKA" } );
            combvol.Text = combvol.Items[ 0 ].ToString( );
            combtype.Text = combtype.Items[ 0 ].ToString( );
        }

        public Product NewProduct( int id )
        {
            try {
                #region Set Product's Proprieties
                v = combvol.Text;
                // create a product with teh wuantity 0 at first 
                qu = 0; 
                // then call ComingStorage() to update it with the real quantity
                type = combtype.Text;
                lab = tboxlabel.Text;
                pr = float.Parse( tboxprice.Text );
                #endregion
                Product foo =  new Product( id, v, type, lab, qu, pr );
                
                // set the real quantity value to pick-it-up from the CRUDFrom
                qu = int.Parse( numquan.Value.ToString( ) );

                // return the product with 0 at quantity
                return foo;
            } catch( Exception ) {

                MessageBox.Show( "make sure you have correct feilds!" );
                return null;
            }
        }

        public void UpdateProduct( Product prod )
        {
            combvol.Text = prod.Volume;
            numquan.Value = prod.Storage.Quantity;
            combtype.Text = prod.Type;
            tboxlabel.Text = prod.Lable;
            tboxprice.Text = prod.Unit_Price.ToString( );
        }
    }
}
