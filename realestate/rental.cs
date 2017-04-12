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
    public partial class rental : Form
    {
        DataSet ds = new DataSet();
        public string sess = null;
        public string selected = null;
        public rental(string selected,string sess1)
        {
            sess = sess1;
            InitializeComponent();
        }
        private void rental_Load(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");

            if (selected == "c")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT c.pr_ID, name, p.address, ss.rent, ss.deposit, sqfeet, storage from (commercial_unit c join Property p on (p.pr_id = c.pr_id)), person pp, rent_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from rent_unit);", conn);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT c.pr_ID, name, p.address, ss.rent, ss.deposit, bhk, furnished from (residential_unit c join Property p on (p.pr_id = c.pr_id)), person pp, rent_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from rent_unit);", conn);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void housesToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            //commercial
            String selected = "c";
            rental r1 = new rental(selected, sess);
            r1.Show();
            this.Hide();
        }


        private void flatsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //resendential
            String selected = "h";
            rental r1 = new rental(selected, sess);
            r1.Show();
            this.Hide();
        }

        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //commercial
            String selected = "c";
            Sale r1 = new Sale(selected, sess);
            r1.Show();
            this.Hide();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resdential
            String selected = "h";
            Sale r1 = new Sale(selected, sess);
            r1.Show();
            this.Hide();
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int id1 = Int32.Parse(id);
                propD pr = new propD(id1);
                pr.Show();
                this.Hide();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
