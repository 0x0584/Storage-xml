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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dpicker = new System.Windows.Forms.DateTimePicker();
            this.label_date = new System.Windows.Forms.Label();
            this.label_storage_info = new System.Windows.Forms.Label();
            this.btn_updown = new System.Windows.Forms.Button();
            this.datagrid_total = new System.Windows.Forms.DataGridView();
            this.label_resume = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.societyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jIMEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.centralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagrid_out = new System.Windows.Forms.DataGridView();
            this.datagrid_in = new System.Windows.Forms.DataGridView();
            this.label_out_sum = new System.Windows.Forms.Label();
            this.label_in_sum = new System.Windows.Forms.Label();
            this.rdbtn_in = new System.Windows.Forms.RadioButton();
            this.rdbtn_rest = new System.Windows.Forms.RadioButton();
            this.rdbtn_out = new System.Windows.Forms.RadioButton();
            this.datagrid_rest = new System.Windows.Forms.DataGridView();
            this.label_rest_sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_storage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_total)).BeginInit();
            this.ms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_rest)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_storage
            // 
            this.datagrid_storage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_storage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_storage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.datagrid_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_storage.DefaultCellStyle = dataGridViewCellStyle20;
            this.datagrid_storage.Location = new System.Drawing.Point(18, 414);
            this.datagrid_storage.Name = "datagrid_storage";
            this.datagrid_storage.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_storage.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.datagrid_storage.Size = new System.Drawing.Size(655, 198);
            this.datagrid_storage.TabIndex = 0;
            this.datagrid_storage.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_storage_CellEnter);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(102, 318);
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
            this.combproducts.Location = new System.Drawing.Point(6, 17);
            this.combproducts.Name = "combproducts";
            this.combproducts.Size = new System.Drawing.Size(170, 24);
            this.combproducts.TabIndex = 2;
            this.combproducts.SelectedIndexChanged += new System.EventHandler(this.combproducts_SelectedIndexChanged);
            this.combproducts.TextUpdate += new System.EventHandler(this.combproducts_TextUpdate);
            // 
            // listadded
            // 
            this.listadded.FormattingEnabled = true;
            this.listadded.ItemHeight = 16;
            this.listadded.Location = new System.Drawing.Point(8, 103);
            this.listadded.Name = "listadded";
            this.listadded.Size = new System.Drawing.Size(172, 212);
            this.listadded.TabIndex = 3;
            this.listadded.SelectedIndexChanged += new System.EventHandler(this.listadded_SelectedIndexChanged);
            // 
            // numquantity
            // 
            this.numquantity.Location = new System.Drawing.Point(67, 44);
            this.numquantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numquantity.Name = "numquantity";
            this.numquantity.Size = new System.Drawing.Size(109, 23);
            this.numquantity.TabIndex = 4;
            // 
            // btnaddtolist
            // 
            this.btnaddtolist.Location = new System.Drawing.Point(8, 74);
            this.btnaddtolist.Name = "btnaddtolist";
            this.btnaddtolist.Size = new System.Drawing.Size(74, 23);
            this.btnaddtolist.TabIndex = 5;
            this.btnaddtolist.Text = "Add";
            this.btnaddtolist.UseVisualStyleBackColor = true;
            this.btnaddtolist.Click += new System.EventHandler(this.btnaddtolist_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(100, 74);
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
            this.lablquant.Location = new System.Drawing.Point(3, 46);
            this.lablquant.Name = "lablquant";
            this.lablquant.Size = new System.Drawing.Size(34, 17);
            this.lablquant.TabIndex = 6;
            this.lablquant.Text = "(25)";
            // 
            // labltotal
            // 
            this.labltotal.AutoSize = true;
            this.labltotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.labltotal.Location = new System.Drawing.Point(5, 321);
            this.labltotal.Name = "labltotal";
            this.labltotal.Size = new System.Drawing.Size(54, 17);
            this.labltotal.TabIndex = 6;
            this.labltotal.Text = "TOTAL";
            // 
            // labnotif
            // 
            this.labnotif.AutoSize = true;
            this.labnotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnotif.ForeColor = System.Drawing.Color.Orange;
            this.labnotif.Location = new System.Drawing.Point(207, 358);
            this.labnotif.Name = "labnotif";
            this.labnotif.Size = new System.Drawing.Size(102, 13);
            this.labnotif.TabIndex = 7;
            this.labnotif.Text = "NOTIFICATIONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "STORAGE:";
            // 
            // dpicker
            // 
            this.dpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpicker.Location = new System.Drawing.Point(429, 43);
            this.dpicker.Name = "dpicker";
            this.dpicker.Size = new System.Drawing.Size(183, 23);
            this.dpicker.TabIndex = 10;
            this.dpicker.ValueChanged += new System.EventHandler(this.dpicker_ValueChanged);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Roboto Slab", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_date.Location = new System.Drawing.Point(370, 44);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(53, 19);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Today:";
            // 
            // label_storage_info
            // 
            this.label_storage_info.AutoSize = true;
            this.label_storage_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_storage_info.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_storage_info.Location = new System.Drawing.Point(111, 393);
            this.label_storage_info.Name = "label_storage_info";
            this.label_storage_info.Size = new System.Drawing.Size(396, 18);
            this.label_storage_info.TabIndex = 9;
            this.label_storage_info.Text = "1542 MAD, 35 Product (7 Products has quantity less that 5)";
            // 
            // btn_updown
            // 
            this.btn_updown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updown.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_updown.Location = new System.Drawing.Point(802, 348);
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
            this.datagrid_total.Location = new System.Drawing.Point(688, 433);
            this.datagrid_total.Name = "datagrid_total";
            this.datagrid_total.Size = new System.Drawing.Size(222, 178);
            this.datagrid_total.TabIndex = 14;
            // 
            // label_resume
            // 
            this.label_resume.AutoSize = true;
            this.label_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_resume.Location = new System.Drawing.Point(685, 412);
            this.label_resume.Name = "label_resume";
            this.label_resume.Size = new System.Drawing.Size(110, 18);
            this.label_resume.TabIndex = 9;
            this.label_resume.Text = "TOTAL FINAL";
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.SystemColors.Control;
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.exportToToolStripMenuItem,
            this.societyToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(919, 24);
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
            // exportToToolStripMenuItem
            // 
            this.exportToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.printToolStripMenuItem});
            this.exportToToolStripMenuItem.Name = "exportToToolStripMenuItem";
            this.exportToToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToToolStripMenuItem.Text = "Export";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-P";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // societyToolStripMenuItem
            // 
            this.societyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jIMEDToolStripMenuItem,
            this.centralToolStripMenuItem});
            this.societyToolStripMenuItem.Name = "societyToolStripMenuItem";
            this.societyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.societyToolStripMenuItem.Text = "Society";
            // 
            // jIMEDToolStripMenuItem
            // 
            this.jIMEDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.jIMEDToolStripMenuItem.Name = "jIMEDToolStripMenuItem";
            this.jIMEDToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.jIMEDToolStripMenuItem.Text = "JIMED";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem2.Text = "2013";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem3.Text = "2014";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem4.Text = "2015";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem5.Text = "2016";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem6.Text = "2017";
            // 
            // centralToolStripMenuItem
            // 
            this.centralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.centralToolStripMenuItem.Name = "centralToolStripMenuItem";
            this.centralToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.centralToolStripMenuItem.Text = "Central";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem7.Text = "2016";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem8.Text = "2017";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(128, 291);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(51, 23);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.combproducts);
            this.groupBox1.Controls.Add(this.btnconfirm);
            this.groupBox1.Controls.Add(this.listadded);
            this.groupBox1.Controls.Add(this.numquantity);
            this.groupBox1.Controls.Add(this.btnaddtolist);
            this.groupBox1.Controls.Add(this.btnremove);
            this.groupBox1.Controls.Add(this.lablquant);
            this.groupBox1.Controls.Add(this.labltotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 347);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Find";
            // 
            // datagrid_out
            // 
            this.datagrid_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_out.Location = new System.Drawing.Point(686, 120);
            this.datagrid_out.Name = "datagrid_out";
            this.datagrid_out.ReadOnly = true;
            this.datagrid_out.Size = new System.Drawing.Size(221, 221);
            this.datagrid_out.TabIndex = 22;
            // 
            // datagrid_in
            // 
            this.datagrid_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_in.Location = new System.Drawing.Point(447, 120);
            this.datagrid_in.Name = "datagrid_in";
            this.datagrid_in.ReadOnly = true;
            this.datagrid_in.Size = new System.Drawing.Size(234, 221);
            this.datagrid_in.TabIndex = 23;
            // 
            // label_out_sum
            // 
            this.label_out_sum.AutoSize = true;
            this.label_out_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_out_sum.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_out_sum.Location = new System.Drawing.Point(751, 100);
            this.label_out_sum.Name = "label_out_sum";
            this.label_out_sum.Size = new System.Drawing.Size(61, 18);
            this.label_out_sum.TabIndex = 25;
            this.label_out_sum.Text = "00 MAD";
            // 
            // label_in_sum
            // 
            this.label_in_sum.AutoSize = true;
            this.label_in_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_in_sum.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_in_sum.Location = new System.Drawing.Point(502, 99);
            this.label_in_sum.Name = "label_in_sum";
            this.label_in_sum.Size = new System.Drawing.Size(61, 18);
            this.label_in_sum.TabIndex = 26;
            this.label_in_sum.Text = "00 MAD";
            // 
            // rdbtn_in
            // 
            this.rdbtn_in.AutoSize = true;
            this.rdbtn_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_in.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdbtn_in.Location = new System.Drawing.Point(450, 96);
            this.rdbtn_in.Name = "rdbtn_in";
            this.rdbtn_in.Size = new System.Drawing.Size(46, 21);
            this.rdbtn_in.TabIndex = 28;
            this.rdbtn_in.TabStop = true;
            this.rdbtn_in.Text = "IN:";
            this.rdbtn_in.UseVisualStyleBackColor = true;
            this.rdbtn_in.CheckedChanged += new System.EventHandler(this.rdbtn_in_CheckedChanged);
            // 
            // rdbtn_rest
            // 
            this.rdbtn_rest.AutoSize = true;
            this.rdbtn_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_rest.ForeColor = System.Drawing.Color.Black;
            this.rdbtn_rest.Location = new System.Drawing.Point(207, 99);
            this.rdbtn_rest.Name = "rdbtn_rest";
            this.rdbtn_rest.Size = new System.Drawing.Size(72, 21);
            this.rdbtn_rest.TabIndex = 29;
            this.rdbtn_rest.TabStop = true;
            this.rdbtn_rest.Text = "REST:";
            this.rdbtn_rest.UseVisualStyleBackColor = true;
            this.rdbtn_rest.CheckedChanged += new System.EventHandler(this.rdbtn_rest_CheckedChanged);
            // 
            // rdbtn_out
            // 
            this.rdbtn_out.AutoSize = true;
            this.rdbtn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_out.ForeColor = System.Drawing.Color.DarkRed;
            this.rdbtn_out.Location = new System.Drawing.Point(686, 97);
            this.rdbtn_out.Name = "rdbtn_out";
            this.rdbtn_out.Size = new System.Drawing.Size(64, 21);
            this.rdbtn_out.TabIndex = 30;
            this.rdbtn_out.TabStop = true;
            this.rdbtn_out.Text = "OUT:";
            this.rdbtn_out.UseVisualStyleBackColor = true;
            this.rdbtn_out.CheckedChanged += new System.EventHandler(this.rdbtn_out_CheckedChanged);
            // 
            // datagrid_rest
            // 
            this.datagrid_rest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_rest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_rest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_rest.Location = new System.Drawing.Point(207, 120);
            this.datagrid_rest.Name = "datagrid_rest";
            this.datagrid_rest.ReadOnly = true;
            this.datagrid_rest.Size = new System.Drawing.Size(234, 221);
            this.datagrid_rest.TabIndex = 24;
            // 
            // label_rest_sum
            // 
            this.label_rest_sum.AutoSize = true;
            this.label_rest_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rest_sum.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_rest_sum.Location = new System.Drawing.Point(285, 99);
            this.label_rest_sum.Name = "label_rest_sum";
            this.label_rest_sum.Size = new System.Drawing.Size(65, 18);
            this.label_rest_sum.TabIndex = 27;
            this.label_rest_sum.Text = "00  MAD";
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(919, 620);
            this.Controls.Add(this.datagrid_out);
            this.Controls.Add(this.datagrid_in);
            this.Controls.Add(this.label_out_sum);
            this.Controls.Add(this.label_in_sum);
            this.Controls.Add(this.rdbtn_in);
            this.Controls.Add(this.rdbtn_rest);
            this.Controls.Add(this.rdbtn_out);
            this.Controls.Add(this.datagrid_rest);
            this.Controls.Add(this.label_rest_sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datagrid_total);
            this.Controls.Add(this.btn_updown);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.dpicker);
            this.Controls.Add(this.label_storage_info);
            this.Controls.Add(this.label_resume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labnotif);
            this.Controls.Add(this.datagrid_storage);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms;
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JIMED";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_storage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_total)).EndInit();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_rest)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpicker;
        private System.Windows.Forms.Label label_date;
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
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ToolStripMenuItem exportToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem societyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jIMEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem centralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrid_out;
        private System.Windows.Forms.DataGridView datagrid_in;
        private System.Windows.Forms.Label label_out_sum;
        private System.Windows.Forms.Label label_in_sum;
        private System.Windows.Forms.RadioButton rdbtn_in;
        private System.Windows.Forms.RadioButton rdbtn_rest;
        private System.Windows.Forms.RadioButton rdbtn_out;
        private System.Windows.Forms.DataGridView datagrid_rest;
        private System.Windows.Forms.Label label_rest_sum;
    }
}