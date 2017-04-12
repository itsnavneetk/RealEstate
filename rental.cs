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
    public partial class rental : Form
    {

        public rental(string selected)
        {
            InitializeComponent();
        }
        
        private void housesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String selected = "flat";
            rental r1 = new rental(selected);
            r1.Show();
            this.Hide();
        }

        private void flatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String selected = "flat";
            rental r1 = new rental(selected);
            r1.Show();
            this.Hide();

        }

        private void flatsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            String selected = "house";
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
