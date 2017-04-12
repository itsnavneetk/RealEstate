using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realestate
{
    public partial class login : Form
    {
        public String sess = null;
        public login()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register rs = new register();
            rs.Show();
            this.Hide();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text + " " + textBox2.Text);
            
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM LOGIN WHERE username='"+ textBox1.Text +"' and password='"+ textBox2.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            /* textBox1.Text = dt.Rows[0][0].ToString();
             textBox2.Text = dt.Rows[0][1].ToString();  */
            if (dt.Rows.Count == 1)
            {
                sess = dt.Rows[0][0].ToString();
                string ss = "h";
                rental rr = new rental(ss, sess);
                //MessageBox.Show("llll  " + sess);
                this.Hide();
                rr.Show();
            }
            else
            {
                MessageBox.Show("Incorrect credentials!!");
            }
        }
    }
}
