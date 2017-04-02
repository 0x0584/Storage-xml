using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btngestion_Click(object sender, EventArgs e)
        {
            CRUDForm crud = new CRUDForm();
            Hide();
            crud.ShowDialog();

            crud.Dispose();
            crud.Close();
            Show();
        }
    }
}
