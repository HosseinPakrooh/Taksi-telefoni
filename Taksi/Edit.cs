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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProNet1.Text.Trim() == "") || (txtProNet2.Text.Trim() == "") || (txtProNet3.Text.Trim() == "") || (txtProNet4.Text.Trim() == "") || (txtProNet5.Text.Trim() == "") || (txtProNet6.Text.Trim() == "") || (txtProNet7.Text.Trim() == ""))
                    MessageBox.Show("طلفا همه اطلاعات را وارد کنید");
                else
                {
                    r_tableTableAdapter.UpdateQuery(txtProNet1.Text, txtProNet2.Text, txtProNet3.Text, txtProNet4.Text, txtProNet5.Text, txtProNet6.Text, txtProNet7.Text, int.Parse(txtProNet8.Text));
                    MessageBox.Show("ویرایش انجام شد");
                    txtProNet1.Text = "";
                    txtProNet2.Text = "";
                    txtProNet3.Text = "";
                    txtProNet4.Text = "";
                    txtProNet5.Text = "";
                    txtProNet6.Text = "";
                    txtProNet7.Text = "";
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("لطفا در وارد کردن اطلاعات دقت فرماید");
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.R_table' table. You can move, or remove it, as needed.
            this.r_tableTableAdapter.Fill(this.taksiDBLDataSet.R_table);

        }

        private void txtProNet8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet8.Text == "")
                {
                    txtProNet1.Text = "";
                    txtProNet2.Text = "";
                    txtProNet3.Text = "";
                    txtProNet4.Text = "";
                    txtProNet5.Text = "";
                    txtProNet6.Text = "";
                    txtProNet7.Text = "";
                }
                else
                    r_tableTableAdapter.FillBycode_ranade(taksiDBLDataSet.R_table, int.Parse(txtProNet8.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا در وارد اطلاعات دقت کنید");
            }
        }
    }
}
      