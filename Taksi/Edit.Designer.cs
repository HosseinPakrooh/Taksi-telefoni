﻿namespace Taksi
{
    partial class Edit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProNet7 = new TextBoxtest.TxtProNet();
            this.txtProNet6 = new TextBoxtest.TxtProNet();
            this.txtProNet5 = new TextBoxtest.TxtProNet();
            this.txtProNet4 = new TextBoxtest.TxtProNet();
            this.txtProNet3 = new TextBoxtest.TxtProNet();
            this.txtProNet2 = new TextBoxtest.TxtProNet();
            this.txtProNet1 = new TextBoxtest.TxtProNet();
            this.glassButton1 = new Glass.GlassButton();
            this.r_tableTableAdapter = new Taksi.TaksiDBLDataSetTableAdapters.R_tableTableAdapter();
            this.txtProNet8 = new TextBoxtest.TxtProNet();
            this.label8 = new System.Windows.Forms.Label();
            this.taksiDBLDataSet = new Taksi.TaksiDBLDataSet();
            this.rtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProNet8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProNet7);
            this.groupBox1.Controls.Add(this.txtProNet6);
            this.groupBox1.Controls.Add(this.txtProNet5);
            this.groupBox1.Controls.Add(this.txtProNet4);
            this.groupBox1.Controls.Add(this.txtProNet3);
            this.groupBox1.Controls.Add(this.txtProNet2);
            this.groupBox1.Controls.Add(this.txtProNet1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(703, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ویرایش";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ماشین";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "مدل ماشین";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "تلفن همراه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "تلفن منزل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "کد ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام";
            // 
            // txtProNet7
            // 
            this.txtProNet7.AutoSprator = false;
            this.txtProNet7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "modelmashin", true));
            this.txtProNet7.EnterToTab = true;
            this.txtProNet7.EscToClose = true;
            this.txtProNet7.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet7.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet7.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet7.FocusTextSelect = true;
            this.txtProNet7.Location = new System.Drawing.Point(477, 187);
            this.txtProNet7.MessageEmptyShowDialog = false;
            this.txtProNet7.MessegeEmpty = "";
            this.txtProNet7.MessegeEmptyInFormRight = true;
            this.txtProNet7.MessegeEmptyShowInForm = false;
            this.txtProNet7.Name = "txtProNet7";
            this.txtProNet7.Size = new System.Drawing.Size(100, 20);
            this.txtProNet7.TabIndex = 6;
            this.txtProNet7.TypeAllChar = true;
            this.txtProNet7.TypeDateShamsi = false;
            this.txtProNet7.TypeEnglishOnly = false;
            this.txtProNet7.TypeFarsiOnly = false;
            this.txtProNet7.TypeNumricOnly = false;
            this.txtProNet7.TypeOtherChar = "";
            // 
            // txtProNet6
            // 
            this.txtProNet6.AutoSprator = false;
            this.txtProNet6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "mashin", true));
            this.txtProNet6.EnterToTab = true;
            this.txtProNet6.EscToClose = true;
            this.txtProNet6.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet6.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet6.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet6.FocusTextSelect = true;
            this.txtProNet6.Location = new System.Drawing.Point(69, 112);
            this.txtProNet6.MessageEmptyShowDialog = false;
            this.txtProNet6.MessegeEmpty = "";
            this.txtProNet6.MessegeEmptyInFormRight = true;
            this.txtProNet6.MessegeEmptyShowInForm = false;
            this.txtProNet6.Name = "txtProNet6";
            this.txtProNet6.Size = new System.Drawing.Size(100, 20);
            this.txtProNet6.TabIndex = 5;
            this.txtProNet6.TypeAllChar = true;
            this.txtProNet6.TypeDateShamsi = false;
            this.txtProNet6.TypeEnglishOnly = false;
            this.txtProNet6.TypeFarsiOnly = false;
            this.txtProNet6.TypeNumricOnly = false;
            this.txtProNet6.TypeOtherChar = "";
            // 
            // txtProNet5
            // 
            this.txtProNet5.AutoSprator = false;
            this.txtProNet5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "shomaremanzel", true));
            this.txtProNet5.EnterToTab = true;
            this.txtProNet5.EscToClose = true;
            this.txtProNet5.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet5.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet5.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet5.FocusTextSelect = true;
            this.txtProNet5.Location = new System.Drawing.Point(274, 112);
            this.txtProNet5.MessageEmptyShowDialog = false;
            this.txtProNet5.MessegeEmpty = "";
            this.txtProNet5.MessegeEmptyInFormRight = true;
            this.txtProNet5.MessegeEmptyShowInForm = false;
            this.txtProNet5.Name = "txtProNet5";
            this.txtProNet5.Size = new System.Drawing.Size(100, 20);
            this.txtProNet5.TabIndex = 4;
            this.txtProNet5.TypeAllChar = true;
            this.txtProNet5.TypeDateShamsi = false;
            this.txtProNet5.TypeEnglishOnly = false;
            this.txtProNet5.TypeFarsiOnly = false;
            this.txtProNet5.TypeNumricOnly = false;
            this.txtProNet5.TypeOtherChar = "";
            // 
            // txtProNet4
            // 
            this.txtProNet4.AutoSprator = false;
            this.txtProNet4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "shomare", true));
            this.txtProNet4.EnterToTab = true;
            this.txtProNet4.EscToClose = true;
            this.txtProNet4.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet4.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet4.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet4.FocusTextSelect = true;
            this.txtProNet4.Location = new System.Drawing.Point(477, 112);
            this.txtProNet4.MessageEmptyShowDialog = false;
            this.txtProNet4.MessegeEmpty = "";
            this.txtProNet4.MessegeEmptyInFormRight = true;
            this.txtProNet4.MessegeEmptyShowInForm = false;
            this.txtProNet4.Name = "txtProNet4";
            this.txtProNet4.Size = new System.Drawing.Size(100, 20);
            this.txtProNet4.TabIndex = 3;
            this.txtProNet4.TypeAllChar = true;
            this.txtProNet4.TypeDateShamsi = false;
            this.txtProNet4.TypeEnglishOnly = false;
            this.txtProNet4.TypeFarsiOnly = false;
            this.txtProNet4.TypeNumricOnly = false;
            this.txtProNet4.TypeOtherChar = "";
            // 
            // txtProNet3
            // 
            this.txtProNet3.AutoSprator = false;
            this.txtProNet3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "code_mali", true));
            this.txtProNet3.EnterToTab = true;
            this.txtProNet3.EscToClose = true;
            this.txtProNet3.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet3.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet3.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet3.FocusTextSelect = true;
            this.txtProNet3.Location = new System.Drawing.Point(69, 26);
            this.txtProNet3.MessageEmptyShowDialog = false;
            this.txtProNet3.MessegeEmpty = "";
            this.txtProNet3.MessegeEmptyInFormRight = true;
            this.txtProNet3.MessegeEmptyShowInForm = false;
            this.txtProNet3.Name = "txtProNet3";
            this.txtProNet3.Size = new System.Drawing.Size(100, 20);
            this.txtProNet3.TabIndex = 2;
            this.txtProNet3.TypeAllChar = true;
            this.txtProNet3.TypeDateShamsi = false;
            this.txtProNet3.TypeEnglishOnly = false;
            this.txtProNet3.TypeFarsiOnly = false;
            this.txtProNet3.TypeNumricOnly = false;
            this.txtProNet3.TypeOtherChar = "";
            // 
            // txtProNet2
            // 
            this.txtProNet2.AutoSprator = false;
            this.txtProNet2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "lnam", true));
            this.txtProNet2.EnterToTab = true;
            this.txtProNet2.EscToClose = true;
            this.txtProNet2.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet2.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet2.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet2.FocusTextSelect = true;
            this.txtProNet2.Location = new System.Drawing.Point(274, 25);
            this.txtProNet2.MessageEmptyShowDialog = false;
            this.txtProNet2.MessegeEmpty = "";
            this.txtProNet2.MessegeEmptyInFormRight = true;
            this.txtProNet2.MessegeEmptyShowInForm = false;
            this.txtProNet2.Name = "txtProNet2";
            this.txtProNet2.Size = new System.Drawing.Size(100, 20);
            this.txtProNet2.TabIndex = 1;
            this.txtProNet2.TypeAllChar = true;
            this.txtProNet2.TypeDateShamsi = false;
            this.txtProNet2.TypeEnglishOnly = false;
            this.txtProNet2.TypeFarsiOnly = false;
            this.txtProNet2.TypeNumricOnly = false;
            this.txtProNet2.TypeOtherChar = "";
            // 
            // txtProNet1
            // 
            this.txtProNet1.AutoSprator = false;
            this.txtProNet1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "nam", true));
            this.txtProNet1.EnterToTab = true;
            this.txtProNet1.EscToClose = true;
            this.txtProNet1.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet1.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet1.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet1.FocusTextSelect = true;
            this.txtProNet1.Location = new System.Drawing.Point(477, 29);
            this.txtProNet1.MessageEmptyShowDialog = false;
            this.txtProNet1.MessegeEmpty = "";
            this.txtProNet1.MessegeEmptyInFormRight = true;
            this.txtProNet1.MessegeEmptyShowInForm = false;
            this.txtProNet1.Name = "txtProNet1";
            this.txtProNet1.Size = new System.Drawing.Size(100, 20);
            this.txtProNet1.TabIndex = 0;
            this.txtProNet1.TypeAllChar = true;
            this.txtProNet1.TypeDateShamsi = false;
            this.txtProNet1.TypeEnglishOnly = false;
            this.txtProNet1.TypeFarsiOnly = false;
            this.txtProNet1.TypeNumricOnly = false;
            this.txtProNet1.TypeOtherChar = "";
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.White;
            this.glassButton1.Image = ((System.Drawing.Image)(resources.GetObject("glassButton1.Image")));
            this.glassButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.glassButton1.Location = new System.Drawing.Point(509, 299);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(177, 62);
            this.glassButton1.TabIndex = 6;
            this.glassButton1.Text = "ثبت";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // r_tableTableAdapter
            // 
            this.r_tableTableAdapter.ClearBeforeFill = true;
            // 
            // txtProNet8
            // 
            this.txtProNet8.AutoSprator = false;
            this.txtProNet8.EnterToTab = true;
            this.txtProNet8.EscToClose = true;
            this.txtProNet8.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet8.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet8.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet8.FocusTextSelect = true;
            this.txtProNet8.Location = new System.Drawing.Point(12, 227);
            this.txtProNet8.MessageEmptyShowDialog = false;
            this.txtProNet8.MessegeEmpty = "";
            this.txtProNet8.MessegeEmptyInFormRight = true;
            this.txtProNet8.MessegeEmptyShowInForm = false;
            this.txtProNet8.Name = "txtProNet8";
            this.txtProNet8.Size = new System.Drawing.Size(100, 20);
            this.txtProNet8.TabIndex = 14;
            this.txtProNet8.TypeAllChar = true;
            this.txtProNet8.TypeDateShamsi = false;
            this.txtProNet8.TypeEnglishOnly = false;
            this.txtProNet8.TypeFarsiOnly = false;
            this.txtProNet8.TypeNumricOnly = false;
            this.txtProNet8.TypeOtherChar = "";
            this.txtProNet8.TextChanged += new System.EventHandler(this.txtProNet8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "کد راننده";
            // 
            // taksiDBLDataSet
            // 
            this.taksiDBLDataSet.DataSetName = "TaksiDBLDataSet";
            this.taksiDBLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtableBindingSource
            // 
            this.rtableBindingSource.DataMember = "R_table";
            this.rtableBindingSource.DataSource = this.taksiDBLDataSet;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(698, 373);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.Text = "ویرایش";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBoxtest.TxtProNet txtProNet7;
        private TextBoxtest.TxtProNet txtProNet6;
        private TextBoxtest.TxtProNet txtProNet5;
        private TextBoxtest.TxtProNet txtProNet4;
        private TextBoxtest.TxtProNet txtProNet3;
        private TextBoxtest.TxtProNet txtProNet2;
        private TextBoxtest.TxtProNet txtProNet1;
        private Glass.GlassButton glassButton1;
        public TaksiDBLDataSetTableAdapters.R_tableTableAdapter r_tableTableAdapter;
        private System.Windows.Forms.Label label8;
        private TextBoxtest.TxtProNet txtProNet8;
        private TaksiDBLDataSet taksiDBLDataSet;
        private System.Windows.Forms.BindingSource rtableBindingSource;
    }
}