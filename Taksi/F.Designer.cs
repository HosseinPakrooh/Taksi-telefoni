namespace Taksi
{
    partial class F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F));
            this.txtProNet1 = new TextBoxtest.TxtProNet();
            this.glassButton1 = new Glass.GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srvisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderanadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codemoshtariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comasionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresmanzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresmagsadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taksiDBLDataSet = new Taksi.TaksiDBLDataSet();
            this.f_tableTableAdapter = new Taksi.TaksiDBLDataSetTableAdapters.F_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProNet1
            // 
            this.txtProNet1.AutoSprator = false;
            this.txtProNet1.EnterToTab = true;
            this.txtProNet1.EscToClose = true;
            this.txtProNet1.FocusBackColor = System.Drawing.Color.Yellow;
            this.txtProNet1.FocusFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtProNet1.FocusForeColor = System.Drawing.Color.Blue;
            this.txtProNet1.FocusTextSelect = true;
            this.txtProNet1.Location = new System.Drawing.Point(12, 37);
            this.txtProNet1.MessageEmptyShowDialog = false;
            this.txtProNet1.MessegeEmpty = "";
            this.txtProNet1.MessegeEmptyInFormRight = true;
            this.txtProNet1.MessegeEmptyShowInForm = false;
            this.txtProNet1.Name = "txtProNet1";
            this.txtProNet1.Size = new System.Drawing.Size(107, 20);
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
            this.glassButton1.Location = new System.Drawing.Point(273, 82);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(98, 44);
            this.glassButton1.TabIndex = 1;
            this.glassButton1.Text = "فاکتور";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد سرویس";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srvisDataGridViewTextBoxColumn,
            this.coderanadaDataGridViewTextBoxColumn,
            this.codemoshtariDataGridViewTextBoxColumn,
            this.tarikDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.gematDataGridViewTextBoxColumn,
            this.comasionDataGridViewTextBoxColumn,
            this.addresmanzelDataGridViewTextBoxColumn,
            this.addresmagsadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ftableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(156, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(11, 13);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // srvisDataGridViewTextBoxColumn
            // 
            this.srvisDataGridViewTextBoxColumn.DataPropertyName = "srvis";
            this.srvisDataGridViewTextBoxColumn.HeaderText = "srvis";
            this.srvisDataGridViewTextBoxColumn.Name = "srvisDataGridViewTextBoxColumn";
            this.srvisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coderanadaDataGridViewTextBoxColumn
            // 
            this.coderanadaDataGridViewTextBoxColumn.DataPropertyName = "code_ranada";
            this.coderanadaDataGridViewTextBoxColumn.HeaderText = "code_ranada";
            this.coderanadaDataGridViewTextBoxColumn.Name = "coderanadaDataGridViewTextBoxColumn";
            // 
            // codemoshtariDataGridViewTextBoxColumn
            // 
            this.codemoshtariDataGridViewTextBoxColumn.DataPropertyName = "code_moshtari";
            this.codemoshtariDataGridViewTextBoxColumn.HeaderText = "code_moshtari";
            this.codemoshtariDataGridViewTextBoxColumn.Name = "codemoshtariDataGridViewTextBoxColumn";
            // 
            // tarikDataGridViewTextBoxColumn
            // 
            this.tarikDataGridViewTextBoxColumn.DataPropertyName = "tarik";
            this.tarikDataGridViewTextBoxColumn.HeaderText = "tarik";
            this.tarikDataGridViewTextBoxColumn.Name = "tarikDataGridViewTextBoxColumn";
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "saat";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            // 
            // gematDataGridViewTextBoxColumn
            // 
            this.gematDataGridViewTextBoxColumn.DataPropertyName = "gemat";
            this.gematDataGridViewTextBoxColumn.HeaderText = "gemat";
            this.gematDataGridViewTextBoxColumn.Name = "gematDataGridViewTextBoxColumn";
            // 
            // comasionDataGridViewTextBoxColumn
            // 
            this.comasionDataGridViewTextBoxColumn.DataPropertyName = "comasion";
            this.comasionDataGridViewTextBoxColumn.HeaderText = "comasion";
            this.comasionDataGridViewTextBoxColumn.Name = "comasionDataGridViewTextBoxColumn";
            // 
            // addresmanzelDataGridViewTextBoxColumn
            // 
            this.addresmanzelDataGridViewTextBoxColumn.DataPropertyName = "addres_manzel";
            this.addresmanzelDataGridViewTextBoxColumn.HeaderText = "addres_manzel";
            this.addresmanzelDataGridViewTextBoxColumn.Name = "addresmanzelDataGridViewTextBoxColumn";
            // 
            // addresmagsadDataGridViewTextBoxColumn
            // 
            this.addresmagsadDataGridViewTextBoxColumn.DataPropertyName = "addres_magsad";
            this.addresmagsadDataGridViewTextBoxColumn.HeaderText = "addres_magsad";
            this.addresmagsadDataGridViewTextBoxColumn.Name = "addresmagsadDataGridViewTextBoxColumn";
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
            // f_tableTableAdapter
            // 
            this.f_tableTableAdapter.ClearBeforeFill = true;
            // 
            // F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(383, 138);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.txtProNet1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F";
            this.Text = "F";
            this.Load += new System.EventHandler(this.F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taksiDBLDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxtest.TxtProNet txtProNet1;
        private Glass.GlassButton glassButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TaksiDBLDataSet taksiDBLDataSet;
        private System.Windows.Forms.BindingSource ftableBindingSource;
        private TaksiDBLDataSetTableAdapters.F_tableTableAdapter f_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn srvisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemoshtariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comasionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresmanzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresmagsadDataGridViewTextBoxColumn;
    }
}