using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Taksi
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.R_table' table. You can move, or remove it, as needed.
            this.r_tableTableAdapter.Fill(this.taksiDBLDataSet.R_table);  
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if ((txtProNet1.Text.Trim() == "") || (txtProNet2.Text.Trim() == "") || (txtProNet3.Text.Trim() == "") || (txtProNet4.Text.Trim() == "") || (txtProNet5.Text.Trim() == "") || (txtProNet6.Text.Trim() == "") || (txtProNet7.Text.Trim() == ""))
                MessageBox.Show("طلفا همه اطلاعات را وارد کنید");
            else
            {
                r_tableTableAdapter.InsertQuery(txtProNet1.Text, txtProNet2.Text, txtProNet3.Text, txtProNet4.Text, txtProNet5.Text, txtProNet6.Text, txtProNet7.Text);
                this.r_tableTableAdapter.Fill(this.taksiDBLDataSet.R_table);
                rtableBindingSource.MoveLast();
                string a = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                MessageBox.Show("اطلاعات ذخیره شد کد راننده :  "+a);
                txtProNet1.Text = "";
                txtProNet2.Text = "";
                txtProNet3.Text = "";
                txtProNet4.Text = "";
                txtProNet5.Text = "";
                txtProNet6.Text = "";
                txtProNet7.Text = "";
            }
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            delete d = new delete();
            d.ShowDialog();
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            Edit E = new Edit();
            E.ShowDialog();
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void سرویسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.ShowDialog();
        }

        private void دفترفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forosh f = new Forosh();
            f.ShowDialog();
        }

        private void admin_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.R_table' table. You can move, or remove it, as needed.
            this.r_tableTableAdapter.Fill(this.taksiDBLDataSet.R_table);

            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            MessageBox.Show("ss" + a);
        }

        private void فاکتورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F f = new F();
            f.ShowDialog();
        }
    }
}
