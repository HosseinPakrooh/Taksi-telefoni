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
    public partial class delete1 : Form
    {
        public delete1()
        {
            InitializeComponent();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet1.Text.Trim() == "")
                    MessageBox.Show("کد سرویس را وارد کنید");
                else
                {
                    int b = dataGridView1.CurrentCell.RowIndex;
                    int a = taksiDBLDataSet.F_table.Rows.Count;
                    f_tableTableAdapter.DeleteQuery(int.Parse(txtProNet1.Text));
                    MessageBox.Show("سرویس حذف شد");
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("این کد وجود ندارد");
            }
        }

        private void delete1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.F_table' table. You can move, or remove it, as needed.
            this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);

        }

        private void txtProNet1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet1.Text == "")
                    txtProNet1.Text = "";
                else
                    f_tableTableAdapter.FillBy(taksiDBLDataSet.F_table, int.Parse(txtProNet1.Text));
            }
            catch
            {
                MessageBox.Show("لطفا در وارد کردن اطلاعات دقت کنید");
            }
                    
        }
    }
}
