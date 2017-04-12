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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String selected = "flat";
            sale r1 = new sale(selected);
            r1.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
            String selected = "house";
            rental r1 = new rental(selected);
            r1.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
            
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String selected = "house";
            sale r21 = new sale(selected);
            r21.Show();
            this.Hide();
        }
    }
}
