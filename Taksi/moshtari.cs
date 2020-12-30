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
    public partial class moshtari : Form
    {
        public moshtari()
        {
            InitializeComponent();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtProNet1.Text.Trim() == "") || (txtProNet2.Text.Trim() == "") || (txtProNet3.Text.Trim() == "") || (txtProNet4.Text.Trim() == "") || (txtProNet5.Text.Trim() == "") || (txtProNet6.Text.Trim() == "") || (txtProNet7.Text.Trim() == "") || (txtProNet8.Text.Trim() == "") || (txtProNet9.Text.Trim() == "") || (txtProNet10.Text.Trim() == ""))
                    MessageBox.Show("لطفا همه اطلاعات را وارد کنید");
                else
                {
                    f_tableTableAdapter.InsertQuery(int.Parse(txtProNet4.Text), int.Parse(txtProNet3.Text), txtProNet6.Text, txtProNet5.Text, float.Parse(txtProNet7.Text), float.Parse(txtProNet10.Text), txtProNet8.Text, txtProNet9.Text);
                    this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);
                    txtProNet1.Text = "";
                    txtProNet2.Text = "";
                    txtProNet3.Text = "";
                    txtProNet4.Text = "";
                    txtProNet5.Text = "";
                    txtProNet6.Text = "";
                    txtProNet7.Text = "";
                    txtProNet8.Text = "";
                    txtProNet9.Text = "";
                    txtProNet10.Text = "";
                    rasid x = new rasid();
                    int n = taksiDBLDataSet.F_table.Rows.Count;
                    x.F_tableBindingSource.DataSource = taksiDBLDataSet.F_table[n - 1];
                    x.ShowDialog();
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show("اطلاعات به درستی وارد نشده است لطفا دقت کنید");
            }
        }
            
    private void moshtari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.M_table' table. You can move, or remove it, as needed.
            this.m_tableTableAdapter.Fill(this.taksiDBLDataSet.M_table);

        }

        private void txtProNet3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet3.Text == "")
                {
                    txtProNet1.Text = "";
                    txtProNet2.Text = "";
                    txtProNet8.Text = "";
                }
                else
                    m_tableTableAdapter.FillBy(taksiDBLDataSet.M_table, int.Parse(txtProNet3.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا در وارد کردن دقت کنید");
            }

        }
    }
}
