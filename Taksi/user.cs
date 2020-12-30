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
    public partial class user : Form
    {
        int b;
        public user()
        {
            InitializeComponent();
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            delete1 d = new delete1();
            d.ShowDialog();
        }

        private void user_Load(object sender, EventArgs e)
        {
            this.m_tableTableAdapter.Fill(this.taksiDBLDataSet.M_table);
            this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            try
            {
            int z = dataGridView1.RowCount;
            txtProNet1.Text = z.ToString();
            if (z == 0)
            {
                m_tableTableAdapter.InsertQuery(txtProNet1.Text, txtProNet2.Text, txtProNet8.Text);
                f_tableTableAdapter.InsertQuery(int.Parse(txtProNet4.Text), b + 1, txtProNet6.Text, txtProNet5.Text, float.Parse(txtProNet7.Text), float.Parse(txtProNet10.Text), txtProNet8.Text, txtProNet9.Text);
                txtProNet1.Text = "";
                txtProNet2.Text = "";
                txtProNet4.Text = "";
                txtProNet5.Text = "";
                txtProNet6.Text = "";
                txtProNet7.Text = "";
                txtProNet8.Text = "";
                txtProNet9.Text = "";
                txtProNet10.Text = "";
                this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);
                rasid x = new rasid();
                int n = taksiDBLDataSet.F_table.Rows.Count;
                x.F_tableBindingSource.DataSource = taksiDBLDataSet.F_table[n - 1];
                x.ShowDialog();
            }
            
                else if ((txtProNet1.Text.Trim() == "") || (txtProNet2.Text.Trim() == "")  || (txtProNet4.Text.Trim() == "") || (txtProNet5.Text.Trim() == "") || (txtProNet6.Text.Trim() == "") || (txtProNet7.Text.Trim() == "") || (txtProNet8.Text.Trim() == "") || (txtProNet9.Text.Trim() == "") || (txtProNet10.Text.Trim() == ""))
                    MessageBox.Show("لطفا همه اطلاعات را وارد کنید");
                else 
                {
                    b = m_tableTableAdapter.ScalarQuery().Value;
                    m_tableTableAdapter.InsertQuery(txtProNet1.Text, txtProNet2.Text, txtProNet8.Text);
                    f_tableTableAdapter.InsertQuery(int.Parse(txtProNet4.Text), b+1, txtProNet6.Text, txtProNet5.Text, float.Parse(txtProNet7.Text), float.Parse(txtProNet10.Text), txtProNet8.Text, txtProNet9.Text); 
                    txtProNet1.Text = "";
                    txtProNet2.Text = "";
                    txtProNet4.Text = "";
                    txtProNet5.Text = "";
                    txtProNet6.Text = "";
                    txtProNet7.Text = "";
                    txtProNet8.Text = "";
                    txtProNet9.Text = "";
                    txtProNet10.Text = "";
                    this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);
                    rasid x = new rasid();
                    int n=taksiDBLDataSet.F_table.Rows.Count;
                    x.F_tableBindingSource.DataSource = taksiDBLDataSet.F_table[n - 1];
                    x.ShowDialog();
                }
            }
                catch(Exception )
            {
                MessageBox.Show("اطلاعات به درستی وارد نشده است لطفا دقت کنید");

                }
            }
        private void glassButton2_Click(object sender, EventArgs e)
        {
            moshtari m = new moshtari();
            m.ShowDialog();
        }

        private void user_Activated(object sender, EventArgs e)
        {
            this.m_tableTableAdapter.Fill(this.taksiDBLDataSet.M_table);
            this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);
            this.Refresh();
        }
    }
}
