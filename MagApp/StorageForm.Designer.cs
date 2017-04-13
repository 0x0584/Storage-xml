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
            this.btnremove = new System.Windows.Forms.Button();
            this.lablquant = new System.Windows.Forms.Label();
            this.labltotal = new System.Windows.Forms.Label();
            this.labnotif = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstorage
            // 
            this.dgvstorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstorage.Location = new System.Drawing.Point(188, 27);
            this.dgvstorage.Name = "dgvstorage";
            this.dgvstorage.Size = new System.Drawing.Size(461, 138);
            this.dgvstorage.TabIndex = 0;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(107, 328);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // combproducts
            // 
            this.combproducts.FormattingEnabled = true;
            this.combproducts.Location = new System.Drawing.Point(12, 6);
            this.combproducts.Name = "combproducts";
            this.combproducts.Size = new System.Drawing.Size(170, 21);
            this.combproducts.TabIndex = 2;
            this.combproducts.SelectedIndexChanged += new System.EventHandler(this.combproducts_SelectedIndexChanged);
            this.combproducts.TextUpdate += new System.EventHandler(this.combproducts_TextUpdate);
            // 
            // listadded
            // 
            this.listadded.FormattingEnabled = true;
            this.listadded.Location = new System.Drawing.Point(12, 101);
            this.listadded.Name = "listadded";
            this.listadded.Size = new System.Drawing.Size(172, 212);
            this.listadded.TabIndex = 3;
            this.listadded.SelectedIndexChanged += new System.EventHandler(this.listadded_SelectedIndexChanged);
            // 
            // numquantity
            // 
            this.numquantity.Location = new System.Drawing.Point(40, 33);
            this.numquantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numquantity.Name = "numquantity";
            this.numquantity.Size = new System.Drawing.Size(142, 20);
            this.numquantity.TabIndex = 4;
            // 
            // btnaddtolist
            // 
            this.btnaddtolist.Location = new System.Drawing.Point(12, 72);
            this.btnaddtolist.Name = "btnaddtolist";
            this.btnaddtolist.Size = new System.Drawing.Size(74, 23);
            this.btnaddtolist.TabIndex = 5;
            this.btnaddtolist.Text = "Add";
            this.btnaddtolist.UseVisualStyleBackColor = true;
            this.btnaddtolist.Click += new System.EventHandler(this.btnaddtolist_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(104, 72);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(78, 23);
            this.btnremove.TabIndex = 5;
            this.btnremove.Text = "Remove From List";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // lablquant
            // 
            this.lablquant.AutoSize = true;
            this.lablquant.ForeColor = System.Drawing.Color.Green;
            this.lablquant.Location = new System.Drawing.Point(9, 35);
            this.lablquant.Name = "lablquant";
            this.lablquant.Size = new System.Drawing.Size(25, 13);
            this.lablquant.TabIndex = 6;
            this.lablquant.Text = "(25)";
            // 
            // labltotal
            // 
            this.labltotal.AutoSize = true;
            this.labltotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.labltotal.Location = new System.Drawing.Point(12, 316);
            this.labltotal.Name = "labltotal";
            this.labltotal.Size = new System.Drawing.Size(42, 13);
            this.labltotal.TabIndex = 6;
            this.labltotal.Text = "TOTAL";
            // 
            // labnotif
            // 
            this.labnotif.AutoSize = true;
            this.labnotif.ForeColor = System.Drawing.Color.Maroon;
            this.labnotif.Location = new System.Drawing.Point(9, 375);
            this.labnotif.Name = "labnotif";
            this.labnotif.Size = new System.Drawing.Size(89, 13);
            this.labnotif.TabIndex = 7;
            this.labnotif.Text = "NOTIFICATIONS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(234, 212);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(188, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(219, 212);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(655, 27);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(183, 374);
            this.dataGridView3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(190, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "INITIAL STORAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(187, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "OUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(412, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(652, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "REST";
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labnotif);
            this.Controls.Add(this.labltotal);
            this.Controls.Add(this.lablquant);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnaddtolist);
            this.Controls.Add(this.numquantity);
            this.Controls.Add(this.listadded);
            this.Controls.Add(this.combproducts);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.dgvstorage);
            this.Name = "StorageForm";
            this.Text = "Storage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label lablquant;
        private System.Windows.Forms.Label labltotal;
        private System.Windows.Forms.Label labnotif;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}