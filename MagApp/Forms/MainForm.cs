using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Class;
using System.Collections;
using Core.Printing;
using System.Runtime.InteropServices;

namespace JIMED.Forms
{
    public partial class StorageForm : Form
    {

        #region Local Variables
        // the product that is checked in the combobox
        Product currentprod;

        // somme of all (prices * quantity)
        float total;
        bool isfirstrun = true;
        #endregion
        [DllImport( "Gdi32.dll", EntryPoint = "CreateRoundRectRgn" )]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public StorageForm()
        {
            InitializeComponent( );
            currentprod = new Product( );

            // TODO: get by date in the dpicker
            //
            //var path = new System.Drawing.Drawing2D.GraphicsPath( );
            //path.AddEllipse( 0, 0, labnotif.Width+3, labnotif.Height+1);

            //this.labnotif.Region = new Region( path );
            //labnotif.BackColor = Color.Red;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn( CreateRoundRectRgn( 0, 0, Width, Height, 20, 20 ) );
            textBox1.Region = Region.FromHrgn( CreateRoundRectRgn( 0, 0, textBox1.Width, textBox1.Height, 7, 7 ) );

            // RefreshForm( );
        }

        #region Form-related Methodes
        #region CRUD
        private void NewProduct()
        {
            FillForm fill = new FillForm( );
            Product fooprod;

            fill.ShowDialog( );

            if( !fill.IsDisposed ) {
                if( (fooprod = fill.NewProduct( Product.GenerateID( ) )) != null ) {

                    fooprod.AddXML( );
                    fooprod.Storage.ComingStorage( fooprod, fill.Quantity, Store.ListType.IN );
                    fill.Dispose( );
                    fill.Close( );
                    if( !is_shown ) ShowHide( );
                    RefreshForm( );
                    foreach( DataGridViewRow row in datagrid_storage.Rows )
                        row.Selected = false;

                    datagrid_storage.Rows[ datagrid_storage.Rows.Count - 1 ].Selected = true;
                }
            }
        }
        private void DeleteProduct()
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
        private void UpdateProduct()
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
                // TODO
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
                            bar.Storage.ComingStorage( bar, qu, Store.ListType.IN );
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

        private void StorageForm_Load( object sender, EventArgs e )
        {
            MaximizeBox = false;
            Size = new Size( new Point( 935, 415 ) );

            labltotal.Text = "0.00 MAD";

            total = 0.0f;

            // radio buttons
            rdbtn_in.Enabled = false;

            rdbtn_in.Checked = true;

            if( Product.List.Count == 0 ) {
                MessageBox.Show( "YOU HAVE NO PRODUCTS!!" );
            } else {
                RefreshForm( );
                combproducts.Text = combproducts.Items[ 0 ].ToString( );

                // setup the datagridviews

                btnconfirm.Enabled = false;
                btnremove.Enabled = false;
            }

            isfirstrun = false;

            // $$
            
            // HERE: show the list of in product of today and add a button 
            // to swap between the past and previous ins 
            //datagrid_storage.DataSource = currentprod.Storage.In;
        }

        private void FreshInput()
        {
            if( listadded.Items.Count > 0 ) {
                listadded.Items.Clear( );
                combproducts.Text = combproducts.Items[ 0 ].ToString( );
                numquantity.Value = 0;
                lablquant.Text = "(" + Product.List[ 0 ].Quantity.ToString( ) + ")";
                labnotif.Text = "";
                btnconfirm.Enabled = btnremove.Enabled = false;
            }
        }

        private void RefreshForm()
        {
            // TODO: Changes to the number of days, weeks, months or years
            //

            //label_date.Text = "Today: " + DateTime.Today.ToShortDateString( );
            //                   ^

            datagrid_in.DataSource = Store.SetupList( Store.ListType.IN, dpicker );
            datagrid_out.DataSource = Store.SetupList( Store.ListType.OUT, dpicker );

            datagrid_rest.DataSource = Store.SetupList( Store.ListType.REST, dpicker );

            #region setup datagrid_storage
            if( datagrid_storage.DataSource != null ) {
                List<object> list = new List<object>( );

                #region enhance data preview
                foreach( Product prod in Product.List ) {
                    list.Add( new {
                        ID = prod.Id,
                        prod.Lable,
                        prod.Quantity,
                        prod.Unit_Price,
                        prod.Price,
                        prod.Type,
                        prod.Volume
                    } );
                }
                datagrid_storage.DataSource = list;
                foreach( DataGridViewRow row in datagrid_storage.Rows ) {
                    #region Set row style
                    row.DefaultCellStyle.Font = new Font( "Microsoft Sans Serif",
                                                            11F, (FontStyle.Regular),
                                                            GraphicsUnit.Point, 0 );
                    // 2 quantity | 1 label | 4 uprice 
                    row.Cells[ 2 ].Style.Font = row.Cells[ 1 ].Style.Font =
                    row.Cells[ 4 ].Style.Font = new Font( "Microsoft Sans Serif",
                                                            12F, (FontStyle.Bold),
                                                            GraphicsUnit.Point, 0 );
                    // row.Cells[ 2 ].Style.ForeColor = row.Cells[ 1 ].Style.ForeColor =
                    //row.Cells[ 4 ].Style.ForeColor = Color.Orange;
                    #endregion
                }
                #endregion
                #region Update label

                float totall = 0.0f;
                foreach( Product prod in Product.List )
                    foreach( DataGridViewRow item in datagrid_storage.Rows ) {
                        string label = item.Cells[ 1 ].Value.ToString( );
                        if( prod.Lable == label ) {
                            string qu = item.Cells[ 2 ].Value.ToString( );
                            totall += float.Parse( (int.Parse( qu ) * (prod.Unit_Price)).ToString( ) );
                            break;
                        }
                    }
                #endregion

                string total = label_rest_sum.Text;
                int count = 0;

                #region Count the number of Products less than the Min
                foreach( Product prod in Product.List )
                    if( prod.IsLessThanMin ) {
                        ++count;
                        foreach( DataGridViewRow row in datagrid_storage.Rows ) {
                            if( prod.Id == int.Parse( row.Cells[ 0 ].Value.ToString( ) ) ) {
                                foreach( DataGridViewCell cell in row.Cells ) {
                                    cell.Style.ForeColor = Color.Magenta;

                                }
                                row.DefaultCellStyle.Font = new Font( "Microsoft Sans Serif", 12F,
                                                                    (FontStyle.Italic),
                                                                    GraphicsUnit.Point, 0 );
                            }
                        }
                    }
                #endregion

                total += string.Format( ", {2} Products ({0} products less than {1})", count,
                                        Product.MinQuantity, Product.List.Count );

                label_storage_info.Text = total;
                //
            }
            #endregion

            if( datagrid_total.DataSource != null )
                datagrid_total.DataSource = GetTotal( );


            #region ComboBox Setup
            combproducts.Items.Clear( );
            // add things
            foreach( Product prod in Product.List )
                combproducts.Items.Add( prod.Lable );

            combproducts.Items.Add( "<New>" );
            #endregion

            #region Select First Row

            if( datagrid_in.Rows.Count > 0 )
                datagrid_in.Rows[ 0 ].Selected = rdbtn_in.Checked;

            if( datagrid_out.Rows.Count > 0 )
                datagrid_out.Rows[ 0 ].Selected = rdbtn_out.Checked;

            if( datagrid_rest.Rows.Count > 0 ) {
                // TODO: select the product at the in or out radios
                //

                datagrid_rest.Rows[ 0 ].Selected = true;
                UpdateTotalLabel( datagrid_rest, label_rest_sum, false );
            }

            if( datagrid_storage.Rows.Count > 0 )
                datagrid_storage.Rows[ 0 ].Selected = true;
            #endregion

            //FreshInput( );
            //if( !( rdbtn_in.Enabled ) )
            //    BackColor = Color.LimeGreen;
            //else BackColor = Color.Orange;
        }

        private object GetTotal()
        {
            // TTC TVA PU of all the INs and OUTs and The rest
            throw new NotImplementedException( );
        }

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
            // done;

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
            string content = "";

            #region setup message
            content += rdbtn_in.Checked ? "IN:\n\n" : "OUT:\n\n";
            content += listadded.Items[ 0 ].ToString( );
            for( int i = 1; i < listadded.Items.Count; i++ )
                content += ("\n" + listadded.Items[ i ].ToString( ));
            #endregion

            if( MessageBox.Show( content, "confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes ) {
                // list all added items
                foreach( string item in listadded.Items ) {
                    string[ ] str = item.Split( new char[ ] { '(', ')' } );
                    string lable = str[ 0 ].TrimEnd( );
                    int q = int.Parse( str[ 1 ].TrimEnd( ) );
                    // List all the products
                    foreach( Product prod in Product.List )
                        if( prod.Lable == lable ) {
                            if( rdbtn_out.Checked && prod.Quantity < q ) {
                                labnotif.Text = string.Format( "YOU ONLY GOT {0} OF {1}",
                                    prod.Quantity, prod.Lable.ToUpper( ) );
                                goto OUT_OF_RANGE;
                            } else {
                                labnotif.Text = "";
                            }
                            Store.ListType type;

                            if( rdbtn_in.Checked ) type = Store.ListType.IN;
                            else if( rdbtn_out.Checked ) type = Store.ListType.OUT;
                            else type = Store.ListType.REST;

                            prod.Storage.ComingStorage( prod, q, type );
                            OUT_OF_RANGE: break;
                        }
                }

                RefreshForm( );
                FreshInput( );
            }
        }

        bool is_shown = false;
        private void ShowHide()
        {
            if( !is_shown ) {
                is_shown = true;
                btn_updown.Text = "HIDE     ▲";
                btn_updown.ForeColor = Color.Orange;

                if( Product.List.Count != 0 ) {
                    datagrid_storage.DataSource = Product.List;
                    datagrid_storage.Rows[ 0 ].Selected = true;
                }

                Size = new Size( new Point( 935, 658 ) );
            } else {
                is_shown = false;
                btn_updown.Text = "SHOW    ▼";
                btn_updown.ForeColor = Color.LimeGreen;

                // clear the datagrid to incress performence
                datagrid_storage.DataSource = null;

                Size = new Size( new Point( 935, 415 ) );
            }
        }

        private void btn_updown_Click( object sender, EventArgs e )
        {
            ShowHide( );
            RefreshForm( );
        }

        private void btnclear_Click( object sender, EventArgs e )
        {
            FreshInput( );
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
            if( combproducts.Text == "<New>" ) {
                NewProduct( );
                combproducts.Text = combproducts.Items[ 0 ].ToString( );
                return;
            }

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
            rdbtn_in.BackColor = Color.Orange;
            datagrid_in.BorderStyle = BorderStyle.FixedSingle;
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            rdbtn_out.Enabled = true;
            rdbtn_out.BackColor = SystemColors.Control;
            datagrid_out.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

            rdbtn_rest.Enabled = true;
            rdbtn_rest.BackColor = SystemColors.Control;
            datagrid_rest.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_rest.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

            RefreshForm( );
        }

        private void rdbtn_out_CheckedChanged( object sender, EventArgs e )
        {
            rdbtn_out.Enabled = false;
            rdbtn_out.BackColor = Color.Orange;
            datagrid_out.BorderStyle = BorderStyle.FixedSingle;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            rdbtn_in.Enabled = true;
            rdbtn_in.BackColor = SystemColors.Control;
            datagrid_in.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

            rdbtn_rest.Enabled = true;
            rdbtn_rest.BackColor = SystemColors.Control;
            datagrid_rest.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_rest.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

            RefreshForm( );
        }

        private void rdbtn_rest_CheckedChanged( object sender, EventArgs e )
        {
            rdbtn_rest.Enabled = false;
            rdbtn_rest.BackColor = Color.Orange;
            datagrid_rest.BorderStyle = BorderStyle.FixedSingle;
            rdbtn_rest.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold), GraphicsUnit.Point, 0 );

            rdbtn_out.Enabled = true;
            rdbtn_out.BackColor = SystemColors.Control;
            datagrid_out.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_out.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

            rdbtn_in.Enabled = true;
            rdbtn_in.BackColor = SystemColors.Control;
            datagrid_in.BorderStyle = BorderStyle.Fixed3D;
            rdbtn_in.Font = new Font( "Microsoft Sans Serif", 10F, (FontStyle.Bold | FontStyle.Italic), GraphicsUnit.Point, 0 );

        }
        #endregion

        #region DataGridView Events

        private void SelectFullRow( DataGridView dgv )
        {
            if( dgv.SelectedCells.Count > 0 ) {
                int __rowindex = dgv.SelectedCells[ 0 ].RowIndex;
                DataGridViewRow drow = dgv.Rows[ __rowindex ];

                foreach( DataGridViewRow row in dgv.Rows ) {
                    int rowindex = row.Cells[ 0 ].RowIndex;
                    bool isit = (rowindex == __rowindex);

                    if( isit ) row.Selected = true;
                    else row.Selected = false;
                }
            }
        }

        private void UpdateTotalLabel( DataGridView dgv, Label labl, bool useprice )
        {

            float total = 0.0f;

            foreach( Product prod in Product.List )
                foreach( DataGridViewRow row in dgv.Rows ) {
                    #region Set row style
                    row.DefaultCellStyle.Font = new Font( "Microsoft Sans Serif",
                                                            10.00F, (FontStyle.Regular),
                                                            GraphicsUnit.Point, 0 );
                    // 2 quantity | 1 label | 4 uprice 
                    row.Cells[ 0 ].Style.Font = row.Cells[ 1 ].Style.Font = new Font( "Microsoft Sans Serif",
                                                            12F, (FontStyle.Regular),
                                                            GraphicsUnit.Point, 0 );
                    row.Cells[ 0 ].Style.ForeColor = row.Cells[ 1 ].Style.ForeColor = Color.Black;
                    #endregion

                    string label = row.Cells[ 0 ].Value.ToString( );
                    if( prod.Lable == label ) {
                        string qu = row.Cells[ 1 ].Value.ToString( );
                        total += float.Parse( (int.Parse( qu ) * (useprice ? prod.Price : prod.Unit_Price)).ToString( ) );
                        break;
                    }
                }

            labl.Text = Math.Abs( total ).ToString( ) + " MAD";
        }

        private void datagrid_storage_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_storage );
        }

        private void datagrid_rest_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_rest );
        }

        #region datagrid_out

        private void datagrid_out_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_out );
        }

        private void datagrid_out_RowsAdded( object sender, DataGridViewRowsAddedEventArgs e )
        {
            //if( !isfirstrun ) {
            //    //RefreshForm( );
            //    foreach( DataGridViewRow row in datagrid_out.Rows )
            //        row.Selected = false;

            //    datagrid_out.Rows[ datagrid_out.Rows.Count - 1 ].Selected = true;
            //}
            UpdateTotalLabel( datagrid_out, label_out_sum, true );
        }
        #endregion

        #region datagrid_in

        private void datagrid_in_CellEnter( object sender, DataGridViewCellEventArgs e )
        {
            SelectFullRow( datagrid_in );
        }

        private void datagrid_in_RowsAdded( object sender, DataGridViewRowsAddedEventArgs e )
        {
            //if( !isfirstrun ) {
            //    //RefreshForm( );
            //    foreach( DataGridViewRow row in datagrid_in.Rows )
            //        row.Selected = false;

            //    datagrid_in.Rows[ datagrid_in.Rows.Count - 1 ].Selected = true;
            //}
            UpdateTotalLabel( datagrid_in, label_in_sum, false );
        }
        #endregion
        #endregion

        #region StripMenu
        private void newProductToolStripMenuItem_Click( object sender, EventArgs e )
        {
            NewProduct( );
        }
        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            DeleteProduct( );
        }
        private void updateToolStripMenuItem_Click( object sender, EventArgs e )
        {
            UpdateProduct( );
        }
        private void pDFToolStripMenuItem_Click( object sender, EventArgs e )
        {
            // find how to export a pdf
        }
        private void printToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( !is_shown ) ShowHide( );
            Printing.DataGridView2Print( datagrid_storage );
        }
        private void excelToolStripMenuItem_Click( object sender, EventArgs e )
        {
            // find how to export to excel
        }
        #endregion

        private void dpicker_ValueChanged( object sender, EventArgs e )
        {
            RefreshForm( );
        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

            foreach( Product prod in Product.List )
                if( textBox1.Text.ToUpper( ) == prod.Lable.ToUpper( ) ) {
                    if( datagrid_storage.DataSource == null ) { ShowHide( ); RefreshForm( ); }
                    foreach( DataGridViewRow row in datagrid_storage.Rows )
                        row.Selected = row.Cells[ 0 ].Value.ToString( ) == prod.Id.ToString( );
                }

        }
        #endregion
    }
}

