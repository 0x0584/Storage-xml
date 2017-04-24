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
    public partial class ErrorFrom : Form
    {
        public ErrorFrom()
        {
            InitializeComponent( );
        }

        private void btn_close_Click( object sender, EventArgs e )
        {
            Dispose( );
            Close( );
        }

        private void btn_create_Click( object sender, EventArgs e )
        {
            CRUDForm crud = new CRUDForm( );

            crud.ShowDialog( );
            crud.Dispose( );
            crud.Close( );
        }
    }
}
