namespace Taksi
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.glassButton1 = new Glass.GlassButton();
            this.glassButton2 = new Glass.GlassButton();
            this.txtProNet1 = new TextBoxtest.TxtProNet();
            this.txtProNet2 = new TextBoxtest.TxtProNet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.White;
            this.glassButton1.Location = new System.Drawing.Point(197, 215);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(75, 34);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "ورود";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // glassButton2
            // 
            this.glassButton2.BackColor = System.Drawing.Color.White;
            this.glassButton2.Location = new System.Drawing.Point(12, 215);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(75, 34);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "خروج";
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
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
            this.txtProNet1.Location = new System.Drawing.Point(12, 33);
            this.txtProNet1.MessageEmptyShowDialog = false;
            this.txtProNet1.MessegeEmpty = "";
            this.txtProNet1.MessegeEmptyInFormRight = true;
            this.txtProNet1.MessegeEmptyShowInForm = false;
            this.txtProNet1.Name = "txtProNet1";
            this.txtProNet1.Size = new System.Drawing.Size(158, 20);
            this.txtProNet1.TabIndex = 2;
            this.txtProNet1.TypeAllChar = true;
            this.txtProNet1.TypeDateShamsi = false;
            this.txtProNet1.TypeEnglishOnly = false;
            this.txtProNet1.TypeFarsiOnly = false;
            this.txtProNet1.TypeNumricOnly = false;
            this.txtProNet1.TypeOtherChar = "";
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
            this.txtProNet2.Location = new System.Drawing.Point(12, 135);
            this.txtProNet2.MessageEmptyShowDialog = false;
            this.txtProNet2.MessegeEmpty = "";
            this.txtProNet2.MessegeEmptyInFormRight = true;
            this.txtProNet2.MessegeEmptyShowInForm = false;
            this.txtProNet2.Name = "txtProNet2";
            this.txtProNet2.PasswordChar = '*';
            this.txtProNet2.Size = new System.Drawing.Size(158, 20);
            this.txtProNet2.TabIndex = 3;
            this.txtProNet2.TypeAllChar = true;
            this.txtProNet2.TypeDateShamsi = false;
            this.txtProNet2.TypeEnglishOnly = false;
            this.txtProNet2.TypeFarsiOnly = false;
            this.txtProNet2.TypeNumricOnly = false;
            this.txtProNet2.TypeOtherChar = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام کابری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "رمز عبور";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProNet2);
            this.Controls.Add(this.txtProNet1);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.glassButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "ورود";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Glass.GlassButton glassButton1;
        private Glass.GlassButton glassButton2;
        private TextBoxtest.TxtProNet txtProNet1;
        private TextBoxtest.TxtProNet txtProNet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

