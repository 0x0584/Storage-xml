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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: here we should take care of all the INs
            //

            StorageForm storage = new StorageForm();
            Hide();
            storage.ShowDialog();

            storage.Dispose();
            storage.Close();
            Show();
        }
    }
}
