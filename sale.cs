using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realestate
{
    public partial class sale : Form
    {
        private string selected;
        public sale(string selected)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void housesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //residential
            String selected = "house";
            rental r1 = new rental(selected);
            r1.Show();
            this.Hide();
        }

        private void flatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Commercial
            String selected = "flat";
            rental r1 = new rental(selected);
            r1.Show();
            this.Hide();
        }

        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selected = "flat";
            sale r1 = new sale(selected);
            r1.Show();
            this.Hide();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selected = "house";
            sale r1 = new sale(selected);
            r1.Show();
            this.Hide();
        }
    }
}
