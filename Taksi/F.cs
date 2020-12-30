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
    public partial class F : Form
    {
        public F()
        {
            InitializeComponent();
        }

        private void F_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taksiDBLDataSet.F_table' table. You can move, or remove it, as needed.
            this.f_tableTableAdapter.Fill(this.taksiDBLDataSet.F_table);

        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProNet1.Text.Trim() == "")
                    MessageBox.Show("لطفا کد سرویس را وارد کنید");
                else
                {
                 int f=ftableBindingSource.Find("srvis", txtProNet1.Text);
                 ftableBindingSource.Position = f;
                 rasid r = new rasid();
                 r.F_tableBindingSource.DataSource = taksiDBLDataSet.F_table[f];
                 r.ShowDialog();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("این کد وجود ندارد");
            }
        }
    }
}
