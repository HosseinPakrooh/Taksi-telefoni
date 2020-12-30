using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if ((txtProNet1.Text.Trim() == "") || (txtProNet2.Text.Trim() == ""))
                MessageBox.Show("لطفا نام کابری و رمز عبور را وارد کنید ");
            else if ((txtProNet1.Text == "user") && (txtProNet2.Text == "91919"))
            {
                user u = new user();
                this.Hide();
                u.ShowDialog();
            }
            else if ((txtProNet1.Text == "admin") && (txtProNet2.Text == "1377451666"))
            {
                admin a = new admin();
                this.Hide();
                a.ShowDialog();
            }
            else
                MessageBox.Show("نام کابری یا رمز عبور اشتباه است");
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
