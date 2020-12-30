namespace Taksi
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.glassButton2 = new Glass.GlassButton();
            this.glassButton3 = new Glass.GlassButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srvisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codemoshtariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comasionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresmanzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresmagsadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taksiDBLDataSet = new Taksi.TaksiDBLDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProNet10 = new TextBoxtest.TxtProNet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProNet9 = new TextBoxtest.TxtProNet();
            this.txtProNet8 = new TextBoxtest.TxtProNet();
            this.txtProNet7 = new TextBoxtest.TxtProNet();
            this.txtProNet6 = new TextBoxtest.TxtProNet();
            this.txtProNet5 = new TextBoxtest.TxtProNet();
            this.txtProNet4 = new TextBoxtest.TxtProNet();
            this.txtProNet2 = new TextBoxtest.TxtProNet();
            this.txtProNet1 = new TextBoxtest.TxtProNet();
            this.glassButton1 = new Glass.GlassButton();
            this.mtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_tableTableAdapter = new Taksi.TaksiDBLDataSetTableAdapters.F_tableTableAdapter();
            this.m_tableTableAdapter = new Taksi.TaksiDBLDataSetTableAdapters.M_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // glassButton2
            // 
            this.glassButton2.BackColor = System.Drawing.Color.White;
            this.glassButton2.Image = ((System.Drawing.Image)(resources.GetObject("glassButton2.Image")));
            this.glassButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.glassButton2.Location = new System.Drawing.Point(805, 108);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(176, 50);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "اشتراک دار";
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
            // 
            // glassButton3
            // 
            this.glassButton3.BackColor = System.Drawing.Color.White;
            this.glassButton3.Image = ((System.Drawing.Image)(resources.GetObject("glassButton3.Image")));
            this.glassButton3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.glassButton3.Location = new System.Drawing.Point(805, 213);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.Size = new System.Drawing.Size(176, 50);
            this.glassButton3.TabIndex = 2;
            this.glassButton3.Text = "حذف";
            this.glassButton3.Click += new System.EventHandler(this.glassButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srvisDataGridViewTextBoxColumn,
            this.codemoshtariDataGridViewTextBoxColumn,
            this.coderanadaDataGridViewTextBoxColumn,
            this.tarikDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.gematDataGridViewTextBoxColumn,
            this.comasionDataGridViewTextBoxColumn,
            this.addresmanzelDataGridViewTextBoxColumn,
            this.addresmagsadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ftableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 215);
            this.dataGridView1.TabIndex = 3;
            // 
            // srvisDataGridViewTextBoxColumn
            // 
            this.srvisDataGridViewTextBoxColumn.DataPropertyName = "srvis";
            this.srvisDataGridViewTextBoxColumn.HeaderText = "سرویس";
            this.srvisDataGridViewTextBoxColumn.Name = "srvisDataGridViewTextBoxColumn";
            this.srvisDataGridViewTextBoxColumn.ReadOnly = true;
            this.srvisDataGridViewTextBoxColumn.Width = 50;
            // 
            // codemoshtariDataGridViewTextBoxColumn
            // 
            this.codemoshtariDataGridViewTextBoxColumn.DataPropertyName = "code_moshtari";
            this.codemoshtariDataGridViewTextBoxColumn.HeaderText = "کد اشتراک";
            this.codemoshtariDataGridViewTextBoxColumn.Name = "codemoshtariDataGridViewTextBoxColumn";
            this.codemoshtariDataGridViewTextBoxColumn.Width = 50;
            // 
            // coderanadaDataGridViewTextBoxColumn
            // 
            this.coderanadaDataGridViewTextBoxColumn.DataPropertyName = "code_ranada";
            this.coderanadaDataGridViewTextBoxColumn.HeaderText = "کد راننده";
            this.coderanadaDataGridViewTextBoxColumn.Name = "coderanadaDataGridViewTextBoxColumn";
            this.coderanadaDataGridViewTextBoxColumn.Width = 50;
            // 
            // tarikDataGridViewTextBoxColumn
            // 
            this.tarikDataGridViewTextBoxColumn.DataPropertyName = "tarik";
            this.tarikDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.tarikDataGridViewTextBoxColumn.Name = "tarikDataGridViewTextBoxColumn";
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "ساعت";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            // 
            // gematDataGridViewTextBoxColumn
            // 
            this.gematDataGridViewTextBoxColumn.DataPropertyName = "gemat";
            this.gematDataGridViewTextBoxColumn.HeaderText = "قیمت";
            this.gematDataGridViewTextBoxColumn.Name = "gematDataGridViewTextBoxColumn";
            // 
            // comasionDataGridViewTextBoxColumn
            // 
            this.comasionDataGridViewTextBoxColumn.DataPropertyName = "comasion";
            this.comasionDataGridViewTextBoxColumn.HeaderText = "کمیسون";
            this.comasionDataGridViewTextBoxColumn.Name = "comasionDataGridViewTextBoxColumn";
            // 
            // addresmanzelDataGridViewTextBoxColumn
            // 
            this.addresmanzelDataGridViewTextBoxColumn.DataPropertyName = "addres_manzel";
            this.addresmanzelDataGridViewTextBoxColumn.HeaderText = "ادرس منزل";
            this.addresmanzelDataGridViewTextBoxColumn.Name = "addresmanzelDataGridViewTextBoxColumn";
            this.addresmanzelDataGridViewTextBoxColumn.Width = 200;
            // 
            // addresmagsadDataGridViewTextBoxColumn
            // 
            this.addresmagsadDataGridViewTextBoxColumn.DataPropertyName = "addres_magsad";
            this.addresmagsadDataGridViewTextBoxColumn.HeaderText = "ادرس مقصد";
            this.addresmagsadDataGridViewTextBoxColumn.Name = "addresmagsadDataGridViewTextBoxColumn";
            this.addresmagsadDataGridViewTextBoxColumn.Width = 200;
            // 
            // ftableBindingSource
            // 
            this.ftableBindingSource.DataMember = "F_table";
            this.ftableBindingSource.DataSource = this.taksiDBLDataSet;
            // 
            // taksiDBLDataSet
            // 
            this.taksiDBLDataSet.DataSetName = "TaksiDBLDataSet";
            this.taksiDBLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtProNet10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProNet9);
            this.groupBox1.Controls.Add(this.txtProNet8);
            this.groupBox1.Controls.Add(this.txtProNet7);
            this.groupBox1.Controls.Add(this.txtProNet6);
            this.groupBox1.Controls.Add(this.txtProNet5);
            this.groupBox1.Controls.Add(this.txtProNet4);
            this.groupBox1.Controls.Add(this.txtProNet2);
            this.groupBox1.Controls.Add(this.txtProNet1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(718, 280);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سرویس";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "کمیسون";
            // 
            // txtProNet10
            // 
            this.txtProNet10.AutoSprator = false;
            this.txtProNet10.EnterToTab = true;
            this.txtProNet10.EscToClose = true;
            this.txtProNet10.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet10.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet10.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet10.FocusTextSelect = true;
            this.txtProNet10.Location = new System.Drawing.Point(89, 19);
            this.txtProNet10.MessageEmptyShowDialog = false;
            this.txtProNet10.MessegeEmpty = "";
            this.txtProNet10.MessegeEmptyInFormRight = true;
            this.txtProNet10.MessegeEmptyShowInForm = false;
            this.txtProNet10.Name = "txtProNet10";
            this.txtProNet10.Size = new System.Drawing.Size(100, 20);
            this.txtProNet10.TabIndex = 18;
            this.txtProNet10.TypeAllChar = true;
            this.txtProNet10.TypeDateShamsi = false;
            this.txtProNet10.TypeEnglishOnly = false;
            this.txtProNet10.TypeFarsiOnly = false;
            this.txtProNet10.TypeNumricOnly = false;
            this.txtProNet10.TypeOtherChar = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ادرس مقصد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ادرس منزل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "قیمت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ساعت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "تاریخ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "کد راننده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام";
            // 
            // txtProNet9
            // 
            this.txtProNet9.AutoSprator = false;
            this.txtProNet9.EnterToTab = true;
            this.txtProNet9.EscToClose = true;
            this.txtProNet9.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet9.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet9.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet9.FocusTextSelect = true;
            this.txtProNet9.Location = new System.Drawing.Point(89, 212);
            this.txtProNet9.MessageEmptyShowDialog = false;
            this.txtProNet9.MessegeEmpty = "";
            this.txtProNet9.MessegeEmptyInFormRight = true;
            this.txtProNet9.MessegeEmptyShowInForm = false;
            this.txtProNet9.Multiline = true;
            this.txtProNet9.Name = "txtProNet9";
            this.txtProNet9.Size = new System.Drawing.Size(176, 62);
            this.txtProNet9.TabIndex = 8;
            this.txtProNet9.TypeAllChar = true;
            this.txtProNet9.TypeDateShamsi = false;
            this.txtProNet9.TypeEnglishOnly = false;
            this.txtProNet9.TypeFarsiOnly = false;
            this.txtProNet9.TypeNumricOnly = false;
            this.txtProNet9.TypeOtherChar = "";
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
            this.txtProNet8.Location = new System.Drawing.Point(416, 212);
            this.txtProNet8.MessageEmptyShowDialog = false;
            this.txtProNet8.MessegeEmpty = "";
            this.txtProNet8.MessegeEmptyInFormRight = true;
            this.txtProNet8.MessegeEmptyShowInForm = false;
            this.txtProNet8.Multiline = true;
            this.txtProNet8.Name = "txtProNet8";
            this.txtProNet8.Size = new System.Drawing.Size(175, 62);
            this.txtProNet8.TabIndex = 7;
            this.txtProNet8.TypeAllChar = true;
            this.txtProNet8.TypeDateShamsi = false;
            this.txtProNet8.TypeEnglishOnly = false;
            this.txtProNet8.TypeFarsiOnly = false;
            this.txtProNet8.TypeNumricOnly = false;
            this.txtProNet8.TypeOtherChar = "";
            // 
            // txtProNet7
            // 
            this.txtProNet7.AutoSprator = false;
            this.txtProNet7.EnterToTab = true;
            this.txtProNet7.EscToClose = true;
            this.txtProNet7.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet7.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet7.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet7.FocusTextSelect = true;
            this.txtProNet7.Location = new System.Drawing.Point(491, 156);
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
            this.txtProNet6.EnterToTab = true;
            this.txtProNet6.EscToClose = true;
            this.txtProNet6.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet6.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet6.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet6.FocusTextSelect = true;
            this.txtProNet6.Location = new System.Drawing.Point(290, 94);
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
            this.txtProNet5.EnterToTab = true;
            this.txtProNet5.EscToClose = true;
            this.txtProNet5.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet5.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet5.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet5.FocusTextSelect = true;
            this.txtProNet5.Location = new System.Drawing.Point(89, 94);
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
            this.txtProNet4.EnterToTab = true;
            this.txtProNet4.EscToClose = true;
            this.txtProNet4.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet4.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet4.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet4.FocusTextSelect = true;
            this.txtProNet4.Location = new System.Drawing.Point(491, 94);
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
            // txtProNet2
            // 
            this.txtProNet2.AutoSprator = false;
            this.txtProNet2.EnterToTab = true;
            this.txtProNet2.EscToClose = true;
            this.txtProNet2.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet2.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet2.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet2.FocusTextSelect = true;
            this.txtProNet2.Location = new System.Drawing.Point(290, 27);
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
            this.txtProNet1.EnterToTab = true;
            this.txtProNet1.EscToClose = true;
            this.txtProNet1.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet1.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProNet1.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet1.FocusTextSelect = true;
            this.txtProNet1.Location = new System.Drawing.Point(491, 27);
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
            this.glassButton1.Location = new System.Drawing.Point(805, 12);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(176, 50);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "سرویس";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // mtableBindingSource
            // 
            this.mtableBindingSource.DataMember = "M_table";
            this.mtableBindingSource.DataSource = this.taksiDBLDataSet;
            // 
            // f_tableTableAdapter
            // 
            this.f_tableTableAdapter.ClearBeforeFill = true;
            // 
            // m_tableTableAdapter
            // 
            this.m_tableTableAdapter.ClearBeforeFill = true;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(993, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.glassButton3);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.glassButton1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mtableBindingSource, "code_moshtari", true));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "user";
            this.Text = "سرویس";
            this.Activated += new System.EventHandler(this.user_Activated);
            this.Load += new System.EventHandler(this.user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Glass.GlassButton glassButton2;
        private Glass.GlassButton glassButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private TextBoxtest.TxtProNet txtProNet10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextBoxtest.TxtProNet txtProNet9;
        private TextBoxtest.TxtProNet txtProNet8;
        private TextBoxtest.TxtProNet txtProNet7;
        private TextBoxtest.TxtProNet txtProNet6;
        private TextBoxtest.TxtProNet txtProNet5;
        private TextBoxtest.TxtProNet txtProNet4;
        private TextBoxtest.TxtProNet txtProNet2;
        private TextBoxtest.TxtProNet txtProNet1;
        private TaksiDBLDataSet taksiDBLDataSet;
        private System.Windows.Forms.BindingSource ftableBindingSource;
        private TaksiDBLDataSetTableAdapters.F_tableTableAdapter f_tableTableAdapter;
        private System.Windows.Forms.BindingSource mtableBindingSource;
        private TaksiDBLDataSetTableAdapters.M_tableTableAdapter m_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn srvisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemoshtariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comasionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresmanzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresmagsadDataGridViewTextBoxColumn;
        private Glass.GlassButton glassButton1;
    }
}