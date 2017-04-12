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
    public partial class propertyListing : Form
    {
        public int sess;
        public propertyListing(string sess1)
        {
            sess = Int32.Parse(sess1);

            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            radioButton3.Hide();
            radioButton4.Hide();
            button2.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            radioButton3.Show();
            radioButton4.Show();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false && radioButton4.Checked == false)
                MessageBox.Show("Please select type!");
            if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                commercial_sale cs = new commercial_sale(sess);
                cs.Show();
            }
            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                Commercial_rent cr = new Commercial_rent(sess);
                cr.Show();
            }
            if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                Residential_sale cs = new Residential_sale(sess);
                cs.Show();
            }
            if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                Residential_rent rr = new Residential_rent();
                rr.Show();
            }

        }


    }
}
