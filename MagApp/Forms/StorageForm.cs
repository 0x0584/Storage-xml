using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MagApp.Class;
using System.Collections;

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

            // TODO: get by date in the dpicker
            //

            // RefreshForm( );
        }

        #region Form-related Methodes

        private void StorageForm_Load( object sender, EventArgs e )
        {
            Size = new Size( new Point( 912, 406 ) );

            labltotal.Text = "0.00 MAD";

            total = 0.0f;

            // radio buttons
            rdbtn_in.Enabled = false;

            rdbtn_in.Checked = true;

            if( Product.List.Count == 0 ) {
                MessageBox.Show( "YOU HAVE NO PRODUCTS!!" );
            } else {
                combproducts.Text = combproducts.Items[ 0 ].ToString( );

                // setup the datagridviews
                RefreshForm( );

                btnconfirm.Enabled = false;
                btnremove.Enabled = false;
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
            List<object> restt = new List<object>( ),
                inn = new List<object>( ), outt = new List<object>( );

            #region Setup lists
            foreach( Product prod in Product.List )
                foreach( Delivery del in prod.Storage.In ) {
                    string pickstr = dpicker.Value.ToShortDateString( ),
                            today = del.Date.ToShortDateString( );
                    if( del.Id == prod.Id && pickstr == today )
                        inn.Add( new { Product = prod.Lable, Quantity = del.Quantity } );
                }

            foreach( Product prod in Product.List )
                foreach( Delivery del in prod.Storage.Out ) {
                    string pickstr = dpicker.Value.ToShortDateString( ),
                            today = del.Date.ToShortDateString( );
                    if( del.Id == prod.Id && pickstr == today )
                        outt.Add( new { Product = prod.Lable, Quantity = del.Quantity } );
                }

            foreach( Product prod in Product.List )
                restt.Add( new { Label = prod.Lable, Quantity = prod.Quantity } );
            #endregion

            datagrid_in.DataSource = inn;
            datagrid_out.DataSource = outt;

            datagrid_rest.DataSource = restt;

            if( datagrid_storage.DataSource != null )
                datagrid_storage.DataSource = Product.List;

            if( datagrid_total.DataSource != null )
                datagrid_total.DataSource = GetTotal( );


            #region ComboBox Setup
            combproducts.Items.Clear( );
            // add things
            foreach( Product prod in Product.List )
                combproducts.Items.Add( prod.Lable );

            #endregion

            #region Select First Row

            if( datagrid_in.Rows.Count > 0 )
                datagrid_in.Rows[ 0 ].Selected = rdbtn_in.Checked;
            if( datagrid_out.Rows.Count > 0 )
                datagrid_out.Rows[ 0 ].Selected = rdbtn_out.Checked;

            if( datagrid_rest.Rows.Count > 0 )
                // select the product at the in or out radios
                datagrid_rest.Rows[ 0 ].Selected = true;
            if( datagrid_storage.Rows.Count > 0 )
                datagrid_storage.Rows[ 0 ].Selected = true;
            #endregion
            //if( !( rdbtn_in.Enabled ) )
            //    BackColor = Color.LimeGreen;
            //else BackColor = Color.Orange;
        }

        private object GetTotal()
        {
            // TTC TVA PU of all the INs and OUTs and The rest
            throw new NotImplementedException( );
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
                        total += (float.Parse( str[ 1 ] ) * currentprod.Unit_Price);
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
                        price = prod.Unit_Price;
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

        bool is_shown = false;
        private void ShowHide()
        {
            if( !is_shown ) {
                is_shown = true;
                btn_updown.Text = "HIDE     ▲";
                btn_updown.ForeColor = Color.DarkRed;

                datagrid_storage.DataSource = Product.List;
                datagrid_storage.Rows[ 0 ].Selected = true;
                Size = new Size( new Point( 912, 633 ) );
            } else {
                is_shown = false;
                btn_updown.Text = "SHOW    ▼";
                btn_updown.ForeColor = Color.LimeGreen;

                // clear the datagrid to incress performence
                datagrid_storage.DataSource = null;

                Size = new Size( new Point( 912, 406 ) );
            }
        }

        private void btn_updown_Click( object sender, EventArgs e )
        {
            ShowHide( );
        }
        #endregion

        #region Events
        #region ListBox Events

        private void listadded_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listadded.Items.Count != 0 ) btnconfirm.Enabled = btnremove.Enabled = true;
            else btnconfirm.Enabled = btnremove.Enabled = false;

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
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            rdbtn_out.Enabled = true;
            datagrid_out.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

            RefreshForm( );
        }

        private void rdbtn_out_CheckedChanged( object sender, EventArgs e )
        {
            rdbtn_out.Enabled = false;
            datagrid_out.BorderStyle = BorderStyle.FixedSingle;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            rdbtn_in.Enabled = true;
            datagrid_in.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

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

                    if( isit ) row.Selected = true;
                    else row.Selected = false;
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

        #region StripMenu

        private void newProductToolStripMenuItem_Click( object sender, EventArgs e )
        {
            FillForm fill = new FillForm( );
            Product fooprod;

            fill.ShowDialog( );

            if( !fill.IsDisposed ) {
                fooprod = fill.NewProduct( Product.GenerateID( ) );
                fooprod.AddXML( );
                fooprod.Storage.ComingStorage( fooprod, fill.Quantity, true );
                fill.Dispose( );
                fill.Close( );
                if( !is_shown )
                    ShowHide( );
                RefreshForm( );
                foreach( DataGridViewRow row in datagrid_storage.Rows )
                    row.Selected = false;

                datagrid_storage.Rows[ datagrid_storage.Rows.Count - 1 ].Selected = true;
            }



        }

        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( datagrid_storage.DataSource != null )
                if( datagrid_storage.SelectedCells.Count > 0 ) {
                    int scell = datagrid_storage.SelectedCells[ 0 ].RowIndex;
                    DataGridViewRow drow = datagrid_storage.Rows[ scell ];

                    foreach( Product item in Product.List )
                        if( int.Parse( drow.Cells[ 0 ].Value.ToString( ) ) == item.Id ) {
                            item.RemoveXML( );
                            RefreshForm( );
                            break;
                        }
                }
        }

        private void updateToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( datagrid_storage.DataSource != null ) {

                FillForm fill = new FillForm( );
                Product foo;
                int rowindex = 0;

                #region Setup product

                ArrayList a = new ArrayList( );

                if( datagrid_storage.SelectedCells.Count > 0 ) {
                    rowindex = datagrid_storage.SelectedCells[ 0 ].RowIndex;
                    DataGridViewRow drow = datagrid_storage.Rows[ rowindex ];
                    foreach( DataGridViewCell item in drow.Cells )
                        a.Add( item );
                }

                int id = int.Parse( ((DataGridViewCell) a[ 0 ]).Value.ToString( ) ),
                 quantity = int.Parse( ((DataGridViewCell) a[ 1 ]).Value.ToString( ) );
                float price = float.Parse( ((DataGridViewCell) a[ 3 ]).Value.ToString( ) );
                string lable = ((DataGridViewCell) a[ 2 ]).Value.ToString( ),
                volume = ((DataGridViewCell) a[ 4 ]).Value.ToString( ),
                type = ((DataGridViewCell) a[ 5 ]).Value.ToString( );

                foo = new Product( id, volume, type, lable, quantity, price );
                #endregion

                fill.UpdateProduct( foo );
                fill.ShowDialog( );

                if( !fill.IsDisposed ) {
                    foreach( Product item in Product.List )
                        if( item.Id == id ) {
                            Product bar = fill.NewProduct( id );
                            int qu = item.Quantity >= fill.Quantity ? (item.Quantity - fill.Quantity) : fill.Quantity;
                            bar.Storage.ComingStorage( bar, qu, true );
                            item.UpdateXML( bar );
                            break;
                        }

                    fill.Dispose( );
                    fill.Close( );
                    RefreshForm( );
                    datagrid_storage.Rows[ 0 ].Selected = false;
                    datagrid_storage.Rows[ rowindex ].Selected = true;
                }
            }
        }
        #endregion


        private void dpicker_ValueChanged( object sender, EventArgs e )
        {
            RefreshForm( );
        }
        #endregion
    }
}

