namespace MagApp
{
    partial class StorageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvstorage = new System.Windows.Forms.DataGridView();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.combproducts = new System.Windows.Forms.ComboBox();
            this.listadded = new System.Windows.Forms.ListBox();
            this.numquantity = new System.Windows.Forms.NumericUpDown();
            this.btnaddtolist = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lablquant = new System.Windows.Forms.Label();
            this.labltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstorage
            // 
            this.dgvstorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstorage.Location = new System.Drawing.Point(152, 51);
            this.dgvstorage.Name = "dgvstorage";
            this.dgvstorage.Size = new System.Drawing.Size(253, 246);
            this.dgvstorage.TabIndex = 0;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(330, 13);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            // 
            // combproducts
            // 
            this.combproducts.FormattingEnabled = true;
            this.combproducts.Location = new System.Drawing.Point(9, 13);
            this.combproducts.Name = "combproducts";
            this.combproducts.Size = new System.Drawing.Size(137, 21);
            this.combproducts.TabIndex = 2;
            // 
            // listadded
            // 
            this.listadded.FormattingEnabled = true;
            this.listadded.Location = new System.Drawing.Point(9, 85);
            this.listadded.Name = "listadded";
            this.listadded.Size = new System.Drawing.Size(137, 212);
            this.listadded.TabIndex = 3;
            // 
            // numquantity
            // 
            this.numquantity.Location = new System.Drawing.Point(37, 49);
            this.numquantity.Name = "numquantity";
            this.numquantity.Size = new System.Drawing.Size(109, 20);
            this.numquantity.TabIndex = 4;
            // 
            // btnaddtolist
            // 
            this.btnaddtolist.Location = new System.Drawing.Point(152, 13);
            this.btnaddtolist.Name = "btnaddtolist";
            this.btnaddtolist.Size = new System.Drawing.Size(74, 23);
            this.btnaddtolist.TabIndex = 5;
            this.btnaddtolist.Text = "Add To List";
            this.btnaddtolist.UseVisualStyleBackColor = true;
            this.btnaddtolist.Click += new System.EventHandler(this.btnaddtolist_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Remove From List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lablquant
            // 
            this.lablquant.AutoSize = true;
            this.lablquant.ForeColor = System.Drawing.Color.Green;
            this.lablquant.Location = new System.Drawing.Point(6, 51);
            this.lablquant.Name = "lablquant";
            this.lablquant.Size = new System.Drawing.Size(25, 13);
            this.lablquant.TabIndex = 6;
            this.lablquant.Text = "(25)";
            // 
            // labltotal
            // 
            this.labltotal.AutoSize = true;
            this.labltotal.ForeColor = System.Drawing.Color.Maroon;
            this.labltotal.Location = new System.Drawing.Point(232, 18);
            this.labltotal.Name = "labltotal";
            this.labltotal.Size = new System.Drawing.Size(42, 13);
            this.labltotal.TabIndex = 6;
            this.labltotal.Text = "TOTAL";
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 333);
            this.Controls.Add(this.labltotal);
            this.Controls.Add(this.lablquant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnaddtolist);
            this.Controls.Add(this.numquantity);
            this.Controls.Add(this.listadded);
            this.Controls.Add(this.combproducts);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.dgvstorage);
            this.Name = "Storage";
            this.Text = "Storage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstorage;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.ComboBox combproducts;
        private System.Windows.Forms.ListBox listadded;
        private System.Windows.Forms.NumericUpDown numquantity;
        private System.Windows.Forms.Button btnaddtolist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lablquant;
        private System.Windows.Forms.Label labltotal;
    }
}