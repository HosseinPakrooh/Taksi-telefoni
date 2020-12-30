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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.R_table' table. You can move, or remove it, as needed.
            this.r_tableTableAdapter.Fill(this.taksiDBLDataSet.R_table);  
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet1.Text.Trim() == "")
                    MessageBox.Show("لطفا کد راننده را وارد کنید");
                else
                {
                    int b = dataGridView1.CurrentCell.RowIndex;
                    int a = taksiDBLDataSet.R_table.Rows.Count;
                    r_tableTableAdapter.DeleteQuery(int.Parse(txtProNet1.Text));
                    MessageBox.Show("راننده حذف شد");
                    this.Close();
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("راننده مورد نظر وجود ندارد");
            }
        }

        private void txtProNet1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet1.Text == "")
                    txtProNet1.Text = "";
                else
                    r_tableTableAdapter.FillBycode_ranade(taksiDBLDataSet.R_table, int.Parse(txtProNet1.Text));
            }
            catch
            {
                MessageBox.Show("لطفا در وارد کردن اطلاعات دقت کنید");
            }
        }
    }
}
