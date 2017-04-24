namespace JIMED.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_storage = new System.Windows.Forms.DataGridView();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.combproducts = new System.Windows.Forms.ComboBox();
            this.listadded = new System.Windows.Forms.ListBox();
            this.numquantity = new System.Windows.Forms.NumericUpDown();
            this.btnaddtolist = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.lablquant = new System.Windows.Forms.Label();
            this.labltotal = new System.Windows.Forms.Label();
            this.labnotif = new System.Windows.Forms.Label();
            this.datagrid_in = new System.Windows.Forms.DataGridView();
            this.datagrid_out = new System.Windows.Forms.DataGridView();
            this.datagrid_rest = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpicker = new System.Windows.Forms.DateTimePicker();
            this.label_out_sum = new System.Windows.Forms.Label();
            this.label_in_sum = new System.Windows.Forms.Label();
            this.rdbtn_in = new System.Windows.Forms.RadioButton();
            this.rdbtn_out = new System.Windows.Forms.RadioButton();
            this.label_date = new System.Windows.Forms.Label();
            this.label_rest_sum = new System.Windows.Forms.Label();
            this.label_storage_info = new System.Windows.Forms.Label();
            this.btn_updown = new System.Windows.Forms.Button();
            this.datagrid_total = new System.Windows.Forms.DataGridView();
            this.label_resume = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_rest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_total)).BeginInit();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid_storage
            // 
            this.datagrid_storage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_storage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.datagrid_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_storage.DefaultCellStyle = dataGridViewCellStyle14;
            this.datagrid_storage.Location = new System.Drawing.Point(11, 391);
            this.datagrid_storage.Name = "datagrid_storage";
            this.datagrid_storage.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.datagrid_storage.Size = new System.Drawing.Size(645, 198);
            this.datagrid_storage.TabIndex = 0;
            this.datagrid_storage.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_storage_CellEnter);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(105, 338);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(78, 23);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // combproducts
            // 
            this.combproducts.FormattingEnabled = true;
            this.combproducts.Location = new System.Drawing.Point(11, 33);
            this.combproducts.Name = "combproducts";
            this.combproducts.Size = new System.Drawing.Size(170, 21);
            this.combproducts.TabIndex = 2;
            this.combproducts.SelectedIndexChanged += new System.EventHandler(this.combproducts_SelectedIndexChanged);
            this.combproducts.TextUpdate += new System.EventHandler(this.combproducts_TextUpdate);
            // 
            // listadded
            // 
            this.listadded.FormattingEnabled = true;
            this.listadded.Location = new System.Drawing.Point(13, 119);
            this.listadded.Name = "listadded";
            this.listadded.Size = new System.Drawing.Size(172, 212);
            this.listadded.TabIndex = 3;
            this.listadded.SelectedIndexChanged += new System.EventHandler(this.listadded_SelectedIndexChanged);
            // 
            // numquantity
            // 
            this.numquantity.Location = new System.Drawing.Point(39, 60);
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
            this.btnaddtolist.Location = new System.Drawing.Point(13, 90);
            this.btnaddtolist.Name = "btnaddtolist";
            this.btnaddtolist.Size = new System.Drawing.Size(74, 23);
            this.btnaddtolist.TabIndex = 5;
            this.btnaddtolist.Text = "Add";
            this.btnaddtolist.UseVisualStyleBackColor = true;
            this.btnaddtolist.Click += new System.EventHandler(this.btnaddtolist_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(105, 90);
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
            this.lablquant.Location = new System.Drawing.Point(8, 62);
            this.lablquant.Name = "lablquant";
            this.lablquant.Size = new System.Drawing.Size(25, 13);
            this.lablquant.TabIndex = 6;
            this.lablquant.Text = "(25)";
            // 
            // labltotal
            // 
            this.labltotal.AutoSize = true;
            this.labltotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.labltotal.Location = new System.Drawing.Point(11, 343);
            this.labltotal.Name = "labltotal";
            this.labltotal.Size = new System.Drawing.Size(42, 13);
            this.labltotal.TabIndex = 6;
            this.labltotal.Text = "TOTAL";
            // 
            // labnotif
            // 
            this.labnotif.AutoSize = true;
            this.labnotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnotif.ForeColor = System.Drawing.Color.Orange;
            this.labnotif.Location = new System.Drawing.Point(192, 343);
            this.labnotif.Name = "labnotif";
            this.labnotif.Size = new System.Drawing.Size(102, 13);
            this.labnotif.TabIndex = 7;
            this.labnotif.Text = "NOTIFICATIONS";
            // 
            // datagrid_in
            // 
            this.datagrid_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_in.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.datagrid_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_in.DefaultCellStyle = dataGridViewCellStyle17;
            this.datagrid_in.Location = new System.Drawing.Point(195, 110);
            this.datagrid_in.Name = "datagrid_in";
            this.datagrid_in.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_in.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.datagrid_in.Size = new System.Drawing.Size(234, 221);
            this.datagrid_in.TabIndex = 8;
            this.datagrid_in.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_in_CellEnter);
            // 
            // datagrid_out
            // 
            this.datagrid_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_out.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.datagrid_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_out.DefaultCellStyle = dataGridViewCellStyle20;
            this.datagrid_out.Location = new System.Drawing.Point(435, 110);
            this.datagrid_out.Name = "datagrid_out";
            this.datagrid_out.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_out.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.datagrid_out.Size = new System.Drawing.Size(221, 221);
            this.datagrid_out.TabIndex = 8;
            this.datagrid_out.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_out_CellEnter);
            // 
            // datagrid_rest
            // 
            this.datagrid_rest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_rest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_rest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.datagrid_rest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_rest.DefaultCellStyle = dataGridViewCellStyle23;
            this.datagrid_rest.Location = new System.Drawing.Point(662, 110);
            this.datagrid_rest.Name = "datagrid_rest";
            this.datagrid_rest.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_rest.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.datagrid_rest.Size = new System.Drawing.Size(221, 221);
            this.datagrid_rest.TabIndex = 8;
            this.datagrid_rest.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_rest_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "STORAGE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(659, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "REST:";
            // 
            // dpicker
            // 
            this.dpicker.Location = new System.Drawing.Point(409, 39);
            this.dpicker.Name = "dpicker";
            this.dpicker.Size = new System.Drawing.Size(183, 20);
            this.dpicker.TabIndex = 10;
            this.dpicker.ValueChanged += new System.EventHandler(this.dpicker_ValueChanged);
            // 
            // label_out_sum
            // 
            this.label_out_sum.AutoSize = true;
            this.label_out_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_sum.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_out_sum.Location = new System.Drawing.Point(500, 90);
            this.label_out_sum.Name = "label_out_sum";
            this.label_out_sum.Size = new System.Drawing.Size(77, 18);
            this.label_out_sum.TabIndex = 9;
            this.label_out_sum.Text = "1542 MAD";
            // 
            // label_in_sum
            // 
            this.label_in_sum.AutoSize = true;
            this.label_in_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_in_sum.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_in_sum.Location = new System.Drawing.Point(242, 90);
            this.label_in_sum.Name = "label_in_sum";
            this.label_in_sum.Size = new System.Drawing.Size(77, 18);
            this.label_in_sum.TabIndex = 9;
            this.label_in_sum.Text = "1542 MAD";
            // 
            // rdbtn_in
            // 
            this.rdbtn_in.AutoSize = true;
            this.rdbtn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_in.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdbtn_in.Location = new System.Drawing.Point(195, 87);
            this.rdbtn_in.Name = "rdbtn_in";
            this.rdbtn_in.Size = new System.Drawing.Size(46, 21);
            this.rdbtn_in.TabIndex = 11;
            this.rdbtn_in.TabStop = true;
            this.rdbtn_in.Text = "IN:";
            this.rdbtn_in.UseVisualStyleBackColor = true;
            this.rdbtn_in.CheckedChanged += new System.EventHandler(this.rdbtn_in_CheckedChanged);
            // 
            // rdbtn_out
            // 
            this.rdbtn_out.AutoSize = true;
            this.rdbtn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_out.ForeColor = System.Drawing.Color.DarkRed;
            this.rdbtn_out.Location = new System.Drawing.Point(435, 87);
            this.rdbtn_out.Name = "rdbtn_out";
            this.rdbtn_out.Size = new System.Drawing.Size(64, 21);
            this.rdbtn_out.TabIndex = 11;
            this.rdbtn_out.TabStop = true;
            this.rdbtn_out.Text = "OUT:";
            this.rdbtn_out.UseVisualStyleBackColor = true;
            this.rdbtn_out.CheckedChanged += new System.EventHandler(this.rdbtn_out_CheckedChanged);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Roboto Slab", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_date.Location = new System.Drawing.Point(350, 40);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(53, 19);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Today:";
            // 
            // label_rest_sum
            // 
            this.label_rest_sum.AutoSize = true;
            this.label_rest_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rest_sum.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_rest_sum.Location = new System.Drawing.Point(713, 89);
            this.label_rest_sum.Name = "label_rest_sum";
            this.label_rest_sum.Size = new System.Drawing.Size(77, 18);
            this.label_rest_sum.TabIndex = 9;
            this.label_rest_sum.Text = "1542 MAD";
            // 
            // label_storage_info
            // 
            this.label_storage_info.AutoSize = true;
            this.label_storage_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_storage_info.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_storage_info.Location = new System.Drawing.Point(107, 370);
            this.label_storage_info.Name = "label_storage_info";
            this.label_storage_info.Size = new System.Drawing.Size(396, 18);
            this.label_storage_info.TabIndex = 9;
            this.label_storage_info.Text = "1542 MAD, 35 Product (7 Products has quantity less that 5)";
            // 
            // btn_updown
            // 
            this.btn_updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updown.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_updown.Location = new System.Drawing.Point(790, 338);
            this.btn_updown.Name = "btn_updown";
            this.btn_updown.Size = new System.Drawing.Size(93, 23);
            this.btn_updown.TabIndex = 13;
            this.btn_updown.Text = "SHOW    ▼";
            this.btn_updown.UseVisualStyleBackColor = true;
            this.btn_updown.Click += new System.EventHandler(this.btn_updown_Click);
            // 
            // datagrid_total
            // 
            this.datagrid_total.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_total.Location = new System.Drawing.Point(662, 410);
            this.datagrid_total.Name = "datagrid_total";
            this.datagrid_total.Size = new System.Drawing.Size(222, 178);
            this.datagrid_total.TabIndex = 14;
            // 
            // label_resume
            // 
            this.label_resume.AutoSize = true;
            this.label_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_resume.Location = new System.Drawing.Point(662, 389);
            this.label_resume.Name = "label_resume";
            this.label_resume.Size = new System.Drawing.Size(110, 18);
            this.label_resume.TabIndex = 9;
            this.label_resume.Text = "TOTAL FINAL";
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(896, 24);
            this.ms.TabIndex = 16;
            this.ms.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // newProductToolStripMenuItem
            // 
            this.newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            this.newProductToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProductToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newProductToolStripMenuItem.Text = "New";
            this.newProductToolStripMenuItem.Click += new System.EventHandler(this.newProductToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+U";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(509, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 17;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(896, 595);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datagrid_total);
            this.Controls.Add(this.btn_updown);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.rdbtn_out);
            this.Controls.Add(this.rdbtn_in);
            this.Controls.Add(this.dpicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_storage_info);
            this.Controls.Add(this.label_in_sum);
            this.Controls.Add(this.label_rest_sum);
            this.Controls.Add(this.label_out_sum);
            this.Controls.Add(this.label_resume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_rest);
            this.Controls.Add(this.datagrid_out);
            this.Controls.Add(this.datagrid_in);
            this.Controls.Add(this.labnotif);
            this.Controls.Add(this.labltotal);
            this.Controls.Add(this.lablquant);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnaddtolist);
            this.Controls.Add(this.numquantity);
            this.Controls.Add(this.listadded);
            this.Controls.Add(this.combproducts);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.datagrid_storage);
            this.Controls.Add(this.ms);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms;
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JIMED";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_rest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_total)).EndInit();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_storage;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.ComboBox combproducts;
        private System.Windows.Forms.ListBox listadded;
        private System.Windows.Forms.NumericUpDown numquantity;
        private System.Windows.Forms.Button btnaddtolist;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label lablquant;
        private System.Windows.Forms.Label labltotal;
        private System.Windows.Forms.Label labnotif;
        private System.Windows.Forms.DataGridView datagrid_in;
        private System.Windows.Forms.DataGridView datagrid_out;
        private System.Windows.Forms.DataGridView datagrid_rest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpicker;
        private System.Windows.Forms.Label label_out_sum;
        private System.Windows.Forms.Label label_in_sum;
        private System.Windows.Forms.RadioButton rdbtn_in;
        private System.Windows.Forms.RadioButton rdbtn_out;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_rest_sum;
        private System.Windows.Forms.Label label_storage_info;
        private System.Windows.Forms.Button btn_updown;
        private System.Windows.Forms.DataGridView datagrid_total;
        private System.Windows.Forms.Label label_resume;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}