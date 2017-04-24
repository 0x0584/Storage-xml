namespace MagApp.Forms
{
    partial class FillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxlabel = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.numquan = new System.Windows.Forms.NumericUpDown( );
            this.btnconf = new System.Windows.Forms.Button( );
            this.btnclose = new System.Windows.Forms.Button( );
            this.combtype = new System.Windows.Forms.ComboBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.label4 = new System.Windows.Forms.Label( );
            this.label5 = new System.Windows.Forms.Label( );
            this.combvol = new System.Windows.Forms.ComboBox( );
            this.lableproduct = new System.Windows.Forms.Label( );
            this.tboxprice = new System.Windows.Forms.TextBox( );
            this.label6 = new System.Windows.Forms.Label( );
            this.label7 = new System.Windows.Forms.Label( );
            this.label8 = new System.Windows.Forms.Label( );
            ((System.ComponentModel.ISupportInitialize) (this.numquan)).BeginInit( );
            this.SuspendLayout( );
            // 
            // tboxlabel
            // 
            this.tboxlabel.Location = new System.Drawing.Point( 123, 13 );
            this.tboxlabel.Name = "tboxlabel";
            this.tboxlabel.Size = new System.Drawing.Size( 119, 20 );
            this.tboxlabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 16 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 80, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Product\'s Lable";
            // 
            // numquan
            // 
            this.numquan.Location = new System.Drawing.Point( 123, 102 );
            this.numquan.Name = "numquan";
            this.numquan.Size = new System.Drawing.Size( 119, 20 );
            this.numquan.TabIndex = 2;
            // 
            // btnconf
            // 
            this.btnconf.Location = new System.Drawing.Point( 123, 228 );
            this.btnconf.Name = "btnconf";
            this.btnconf.Size = new System.Drawing.Size( 75, 23 );
            this.btnconf.TabIndex = 3;
            this.btnconf.Text = "Confirm";
            this.btnconf.UseVisualStyleBackColor = true;
            this.btnconf.Click += new System.EventHandler( this.btnconf_Click );
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point( 33, 228 );
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size( 75, 23 );
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler( this.btnclose_Click );
            // 
            // combtype
            // 
            this.combtype.FormattingEnabled = true;
            this.combtype.Location = new System.Drawing.Point( 123, 45 );
            this.combtype.Name = "combtype";
            this.combtype.Size = new System.Drawing.Size( 119, 21 );
            this.combtype.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 12, 48 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 49, 13 );
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 12, 104 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 46, 13 );
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 12, 78 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 42, 13 );
            this.label5.TabIndex = 1;
            this.label5.Text = "Volume";
            // 
            // combvol
            // 
            this.combvol.FormattingEnabled = true;
            this.combvol.Location = new System.Drawing.Point( 123, 75 );
            this.combvol.Name = "combvol";
            this.combvol.Size = new System.Drawing.Size( 119, 21 );
            this.combvol.TabIndex = 4;
            // 
            // lableproduct
            // 
            this.lableproduct.AutoSize = true;
            this.lableproduct.Location = new System.Drawing.Point( 70, 193 );
            this.lableproduct.Name = "lableproduct";
            this.lableproduct.Size = new System.Drawing.Size( 93, 13 );
            this.lableproduct.TabIndex = 5;
            this.lableproduct.Text = "Product.ToString()";
            // 
            // tboxprice
            // 
            this.tboxprice.Location = new System.Drawing.Point( 123, 128 );
            this.tboxprice.Name = "tboxprice";
            this.tboxprice.Size = new System.Drawing.Size( 119, 20 );
            this.tboxprice.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 12, 131 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 31, 13 );
            this.label6.TabIndex = 1;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point( 211, 131 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 31, 13 );
            this.label7.TabIndex = 1;
            this.label7.Text = "MAD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point( 102, 78 );
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size( 15, 13 );
            this.label8.TabIndex = 1;
            this.label8.Text = "cl";
            // 
            // FillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 254, 279 );
            this.Controls.Add( this.lableproduct );
            this.Controls.Add( this.combvol );
            this.Controls.Add( this.combtype );
            this.Controls.Add( this.btnclose );
            this.Controls.Add( this.btnconf );
            this.Controls.Add( this.numquan );
            this.Controls.Add( this.label8 );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label7 );
            this.Controls.Add( this.label6 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.tboxprice );
            this.Controls.Add( this.tboxlabel );
            this.Name = "FillForm";
            this.Text = "MainForm1";
            this.Load += new System.EventHandler( this.MainForm_Load );
            ((System.ComponentModel.ISupportInitialize) (this.numquan)).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.TextBox tboxlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numquan;
        private System.Windows.Forms.Button btnconf;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox combtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combvol;
        private System.Windows.Forms.Label lableproduct;
        private System.Windows.Forms.TextBox tboxprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}