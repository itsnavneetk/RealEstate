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
    public partial class propD : Form
    {
        public int id;
        public propD(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void propD_Load(object sender, EventArgs e)
        {

            string query = "Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source =.; Initial Catalog = realestate; Integrated Security = True";
            SqlConnection con = new SqlConnection(query);
            con.Open();

            string query1 = "select p.pr_id, p.address, pp.name, phone, featureName, email from property p join person pp on (pp.p_ID = p.owner_ID) join hasfeatures hf on (hf.pr_id = p.pr_id) join Features f on hf.code = f.code where p.pr_id ='" + id + "'";
            SqlCommand cmd = new SqlCommand(query1, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                label1.Text = dr.GetValue(2).ToString();
                label3.Text = dr.GetValue(1).ToString();
                label4.Text = dr.GetValue(3).ToString();
                label2.Text = dr.GetValue(4).ToString();
                label5.Text = dr.GetValue(5).ToString();

            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
    }

