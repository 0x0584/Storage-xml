using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagApp.Class;

using MagApp.Class;
namespace MagApp.Forms
{
    public partial class StorageForm : Form
    {

        #region Local Variables
        // the product that is checked in the combobox
        Product currentprod;

        // somme of all (prices * quantity)
        float total;
        #endregion

        public StorageForm()
        {
            InitializeComponent( );
            currentprod = new Product( );

            #region ComboBox Setup
            // add things
            foreach( Product prod in Product.List )
                combproducts.Items.Add( prod.Lable );

            #endregion
            // TODO: get by date in the dpicker
            //


            RefreshForm( );
        }

        #region Form-related Methodes
        private void StorageForm_Load( object sender, EventArgs e )
        {
            Size = new Size( new Point( 912, 400 ) );

            labltotal.Text = "0.00 MAD";

            total = 0.0f;

            // radio buttons
            rdbtn_in.Enabled = false;

            rdbtn_in.Checked = true;

            if( Product.List.Count == 0 ) {
                //MessageBox.Show( "YOU HAVE NO PRODUCTS!!" );
               // ErrorFrom 
                Dispose( );
                Close( );
            } else {


                combproducts.Text = combproducts.Items[ 0 ].ToString( );

                // setup the datagridviews
                RefreshForm( );

                btnconfirm.Enabled = false;
            }

            // HERE: show the list of in product of today and add a button 
            // to swap between the past and previous ins 
            //datagrid_storage.DataSource = currentprod.Storage.In;
        }

        private void RefreshForm()
        {
            // TODO: Changes to the number of days, weeks, months or years
            //

            //label_date.Text = "Today: " + DateTime.Today.ToShortDateString( );
            //                   ^

            datagrid_in.DataSource = Store.All_In;
            datagrid_out.DataSource = Store.All_Out;

            //if( !( rdbtn_in.Enabled ) )
            //    BackColor = Color.LimeGreen;
            //else BackColor = Color.Orange;
        }

        //private IEnumerable<Delivery> GetByDate( IEnumerable<Delivery> list, DateTime date )
        //{

        //}
        private string FormatLabel( string lable, decimal quantity )
        {
            return string.Format( "{0} ({1})", lable, quantity );
        }
        #endregion


        #region Buttons
        private void btnaddtolist_Click( object sender, EventArgs e )
        {
            // TODO: fix the add in the list
            // done.

            // TODO: fix the aupdate of the quantity
            // panding..

            string listitem = "";

            /* WHAT: whether the product is already in the list */
            bool /* item */ exists = false;

            int index;
            for( index = 0; index < listadded.Items.Count; ++index ) {
                string lable;
                decimal newvalue = 0;
                bool isit /* the item that we're looking for? */;

                #region prepare the listitem 
                string[ ] str = ((string) listadded.Items[ index ]).Split( new char[ 2 ] { '(', ')' } );
                lable = str[ 0 ].TrimEnd( );
                newvalue = 0;
                listitem = "";
                #endregion

                isit = string.Equals( currentprod.Lable, lable );

                if( isit ) {
                    // add the new and the previous values
                    newvalue = (numquantity.Value + int.Parse( str[ 1 ] ));
                    // update the list item overview
                    listitem = FormatLabel( currentprod.Lable, (numquantity.Value = newvalue) );
                    // flag it's existance
                    exists = true;
                    break;
                }
            }

            if( !(exists) ) {
                // setup a fresh item
                listadded.Items.Add( FormatLabel( currentprod.Lable, numquantity.Value ) );
                // select the item
                listadded.SetSelected( listadded.Items.Count - 1, true );
            } else {
                // it exists!
                // you may want to check this `i`
                listadded.Items[ index ] = listitem;
                listadded.SetSelected( index, true );
            }

            if( listadded.SelectedItem != null ) {
                string[ ] info = listadded.SelectedItem.ToString( ).Split( new char[ 2 ] { '(', ')' } );

                combproducts.Text = info[ 0 ].TrimEnd( );
                numquantity.Value = int.Parse( info[ 1 ] );


                // TODO: find how to take few digits from 
                // the foalt number
                // done.

                foreach( string item in listadded.Items ) {
                    string[ ] str = item.ToString( ).Split( new char[ 2 ] { '(', ')' } );

                    if( string.Equals( str[ 0 ].TrimEnd( ), currentprod.Lable ) ) {
                        total += (float.Parse( str[ 1 ] ) * currentprod.Price);
                        break;
                    }
                }

                labltotal.Text = string.Format( "{0:0.00} MAD", total.ToString( ) );
            }

        }

        private void btnremove_Click( object sender, EventArgs e )
        {
            if( listadded.SelectedItem != null ) {
                int index = listadded.SelectedIndex;
                string[ ] str = listadded.Items[ index ].ToString( ).Split( new char[ ] { '(', ')' } );

                // the total taht is stored in teh label
                float price = 0.0f;

                foreach( Product prod in Product.List )
                    if( string.Equals( prod.Lable, str[ 0 ].TrimEnd( ) ) ) {
                        price = prod.Price;
                        break;
                    }

                // minus teh price of the removed items
                total -= (float.Parse( str[ 1 ] ) * price);

                labltotal.Text = string.Format( "{0} MAD", total.ToString( ) );
                listadded.Items.Remove( listadded.Items[ index ] );
            } else { labnotif.Text = "Select a product first"; }
        }

        private void btnconfirm_Click( object sender, EventArgs e )
        {
            // TODO: bind the datagrid and update the XML file
            //

            // get the current list of comming storage (in-or-out)
            //List<Product> current = new List<Product>( );

            // list all added items
            foreach( string item in listadded.Items ) {
                string[ ] str = item.Split( new char[ ] { '(', ')' } );

                // List all the products
                foreach( Product prod in Product.List )
                    if( prod.Lable == str[ 0 ].TrimEnd( ) ) {
                        //          current.Add( prod );
                        prod.Storage.ComingStorage( prod, int.Parse( str[ 1 ].TrimEnd( ) ), rdbtn_in.Checked );
                        break;
                    }
            }
            RefreshForm( );
            //// bind the datagridview
            //datagrid_storage.DataSource = current.ToList( );
        }

        bool flag = false;
        private void btn_updown_Click( object sender, EventArgs e )
        {
            if( !flag ) {
                flag = true;
                btn_updown.Text = "▲";
                btn_updown.ForeColor = Color.DarkRed;

                datagrid_storage.DataSource = Product.List;
                Size = new Size( new Point( 912, 611 ) );
            } else {
                flag = false;
                btn_updown.Text = "▼";
                btn_updown.ForeColor = Color.LimeGreen;

                // clear the datagrid to incress performence
                datagrid_storage.DataSource = null;

                Size = new Size( new Point( 912, 400 ) );
            }
        }
        #endregion

        #region Events
        #region ListBox Events

        private void listadded_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listadded.Items.Count != 0 ) btnconfirm.Enabled = true;
            else btnconfirm.Enabled = false;

            labnotif.Text = "";
            if( listadded.SelectedItem != null ) {
                string[ ] str = listadded.SelectedItem.ToString( ).Split( new char[ ] { '(', ')' } );
                combproducts.Text = str[ 0 ].TrimEnd( );
                numquantity.Value = decimal.Parse( str[ 1 ] );
            }
        }
        #endregion

        #region ComboBox Events

        private void combproducts_SelectedIndexChanged( object sender, EventArgs e )
        {
            // TODO: update the quantity lable
            // done.

            string labcurrent = combproducts.Text;

            foreach( Product prod in Product.List )
                if( prod.Lable == labcurrent && currentprod.Lable != labcurrent ) {
                    // get the prod
                    prod.CopyTo( currentprod );
                    lablquant.Text = string.Format( "({0})", currentprod.Storage.Quantity );

                    for( int index = 0; index < listadded.Items.Count; ++index ) {
                        string[ ] str = ((string) listadded.Items[ index ]).Split( new char[ ] { '(', ')' } );
                        bool isit /* tisi */ = (str[ 0 ].TrimEnd( ) == labcurrent) ? true : false;

                        listadded.SetSelected( index, isit );

                        if( isit ) {
                            numquantity.Value = int.Parse( str[ 1 ] );
                            // you need a 
                            break; /* you need KitKat */
                        }
                        // rempplace all the foreach-loops witha  standard forloop
                        // half-done.
                    }
                    break; // we found it!
                }
        }

        private void combproducts_TextUpdate( object sender, EventArgs e )
        {
            // update the quantity lable 
            // done

            string labcurrent = combproducts.SelectedItem.ToString( );

            foreach( Product prod in Product.List )
                if( prod.Lable == labcurrent ) { prod.CopyTo( currentprod ); break; }

            lablquant.Text = string.Format( "({0})", currentprod.Storage.Quantity );
        }
        #endregion

        #region RadioButton Events

        private void rdbtn_in_CheckedChanged( object sender, EventArgs e )
        {
            rdbtn_in.Enabled = false;
            datagrid_in.BorderStyle = BorderStyle.FixedSingle;
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Regular | FontStyle.Italic), GraphicsUnit.Point, 0 );

            rdbtn_out.Enabled = true;
            datagrid_out.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            RefreshForm( );
        }

        private void rdbtn_out_CheckedChanged( object sender, EventArgs e )
        {
            rdbtn_out.Enabled = false;
            datagrid_out.BorderStyle = BorderStyle.FixedSingle;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Regular | FontStyle.Italic), GraphicsUnit.Point, 0 );

            rdbtn_in.Enabled = true;
            datagrid_in.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            RefreshForm( );
        }
        #endregion

        #region DataGridView Events

        private void SelectFullRow( DataGridView dgv )
        {
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

        private void datagrid_storage_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_storage );
        }

        private void datagrid_rest_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_rest );
        }

        private void datagrid_out_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_out );
        }

        private void datagrid_in_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_in );
        }
        #endregion

        #endregion

        private void button1_Click( object sender, EventArgs e )
        {
            this.Dispose( );
            this.Close( );
        }
    }
}

