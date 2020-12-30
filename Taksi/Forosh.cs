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
    public partial class Forosh : Form
    {
        public Forosh()
        {
            InitializeComponent();
        }

        private void Forosh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TaksiDBLDataSet.F_table' table. You can move, or remove it, as needed.
            this.F_tableTableAdapter.Fill(this.TaksiDBLDataSet.F_table);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }    
    }
}
