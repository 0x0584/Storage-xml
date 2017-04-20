using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent( );
        }

        private void btngestion_Click( object sender, EventArgs e )
        {
            CRUDForm crud = new CRUDForm( );
            Hide( );
            crud.ShowDialog( );

            if( !(crud.IsDisposed) ) {
                crud.Dispose( );
                crud.Close( );
            }
            Show( );
        }

        private void MainForm_Load( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            // TODO: here we should take care of all the INs
            //

            StorageForm storage = new StorageForm( );
            Hide( );
            storage.ShowDialog( );

            if( !(storage.IsDisposed) )
                storage.Dispose( );
            storage.Close( );
            Show( );
        }
    }
}
