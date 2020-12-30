namespace Taksi
{
    partial class delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            this.glassButton1 = new Glass.GlassButton();
            this.txtProNet1 = new TextBoxtest.TxtProNet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coderanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codemaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shomareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shomaremanzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mashinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelmashinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taksiDBLDataSet = new Taksi.TaksiDBLDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.rtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.r_tableTableAdapter = new Taksi.TaksiDBLDataSetTableAdapters.R_tableTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.White;
            this.glassButton1.Location = new System.Drawing.Point(251, 12);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(103, 44);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "حذف";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
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
            this.txtProNet1.Location = new System.Drawing.Point(12, 36);
            this.txtProNet1.MessageEmptyShowDialog = false;
            this.txtProNet1.MessegeEmpty = "";
            this.txtProNet1.MessegeEmptyInFormRight = true;
            this.txtProNet1.MessegeEmptyShowInForm = false;
            this.txtProNet1.Name = "txtProNet1";
            this.txtProNet1.Size = new System.Drawing.Size(100, 20);
            this.txtProNet1.TabIndex = 1;
            this.txtProNet1.TypeAllChar = true;
            this.txtProNet1.TypeDateShamsi = false;
            this.txtProNet1.TypeEnglishOnly = false;
            this.txtProNet1.TypeFarsiOnly = false;
            this.txtProNet1.TypeNumricOnly = false;
            this.txtProNet1.TypeOtherChar = "";
            this.txtProNet1.TextChanged += new System.EventHandler(this.txtProNet1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد راننده";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(367, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coderanadaDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.lnamDataGridViewTextBoxColumn,
            this.codemaliDataGridViewTextBoxColumn,
            this.shomareDataGridViewTextBoxColumn,
            this.shomaremanzelDataGridViewTextBoxColumn,
            this.mashinDataGridViewTextBoxColumn,
            this.modelmashinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rtableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(81, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(228, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // coderanadaDataGridViewTextBoxColumn
            // 
            this.coderanadaDataGridViewTextBoxColumn.DataPropertyName = "code_ranada";
            this.coderanadaDataGridViewTextBoxColumn.HeaderText = "code_ranada";
            this.coderanadaDataGridViewTextBoxColumn.Name = "coderanadaDataGridViewTextBoxColumn";
            this.coderanadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "nam";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            // 
            // lnamDataGridViewTextBoxColumn
            // 
            this.lnamDataGridViewTextBoxColumn.DataPropertyName = "lnam";
            this.lnamDataGridViewTextBoxColumn.HeaderText = "lnam";
            this.lnamDataGridViewTextBoxColumn.Name = "lnamDataGridViewTextBoxColumn";
            // 
            // codemaliDataGridViewTextBoxColumn
            // 
            this.codemaliDataGridViewTextBoxColumn.DataPropertyName = "code_mali";
            this.codemaliDataGridViewTextBoxColumn.HeaderText = "code_mali";
            this.codemaliDataGridViewTextBoxColumn.Name = "codemaliDataGridViewTextBoxColumn";
            // 
            // shomareDataGridViewTextBoxColumn
            // 
            this.shomareDataGridViewTextBoxColumn.DataPropertyName = "shomare";
            this.shomareDataGridViewTextBoxColumn.HeaderText = "shomare";
            this.shomareDataGridViewTextBoxColumn.Name = "shomareDataGridViewTextBoxColumn";
            // 
            // shomaremanzelDataGridViewTextBoxColumn
            // 
            this.shomaremanzelDataGridViewTextBoxColumn.DataPropertyName = "shomaremanzel";
            this.shomaremanzelDataGridViewTextBoxColumn.HeaderText = "shomaremanzel";
            this.shomaremanzelDataGridViewTextBoxColumn.Name = "shomaremanzelDataGridViewTextBoxColumn";
            // 
            // mashinDataGridViewTextBoxColumn
            // 
            this.mashinDataGridViewTextBoxColumn.DataPropertyName = "mashin";
            this.mashinDataGridViewTextBoxColumn.HeaderText = "mashin";
            this.mashinDataGridViewTextBoxColumn.Name = "mashinDataGridViewTextBoxColumn";
            // 
            // modelmashinDataGridViewTextBoxColumn
            // 
            this.modelmashinDataGridViewTextBoxColumn.DataPropertyName = "modelmashin";
            this.modelmashinDataGridViewTextBoxColumn.HeaderText = "modelmashin";
            this.modelmashinDataGridViewTextBoxColumn.Name = "modelmashinDataGridViewTextBoxColumn";
            // 
            // rtableBindingSource1
            // 
            this.rtableBindingSource1.DataMember = "R_table";
            this.rtableBindingSource1.DataSource = this.taksiDBLDataSet;
            // 
            // taksiDBLDataSet
            // 
            this.taksiDBLDataSet.DataSetName = "TaksiDBLDataSet";
            this.taksiDBLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "lnam", true));
            this.label3.Location = new System.Drawing.Point(173, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // rtableBindingSource
            // 
            this.rtableBindingSource.DataMember = "R_table";
            this.rtableBindingSource.DataSource = this.taksiDBLDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rtableBindingSource, "nam", true));
            this.label2.Location = new System.Drawing.Point(173, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // r_tableTableAdapter
            // 
            this.r_tableTableAdapter.ClearBeforeFill = true;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(366, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProNet1);
            this.Controls.Add(this.glassButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delete";
            this.Text = "حذف";
            this.Load += new System.EventHandler(this.delete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Glass.GlassButton glassButton1;
        private TextBoxtest.TxtProNet txtProNet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TaksiDBLDataSet taksiDBLDataSet;
        private System.Windows.Forms.BindingSource rtableBindingSource;
        private TaksiDBLDataSetTableAdapters.R_tableTableAdapter r_tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shomareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shomaremanzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mashinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelmashinDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rtableBindingSource1;
    }
}