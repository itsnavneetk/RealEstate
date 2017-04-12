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
    
    public partial class Sale : Form
    {
        DataSet ds = new DataSet();
        public string sess = null;
        public string selected = null;
        public Sale(string selected1, string sess1)
        {
            sess = sess1;
            selected = selected1;
            InitializeComponent();
        }


        private void Sale_Load(object sender, EventArgs e)
        {
           
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");

            if (selected == "c")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT c.pr_ID, name, p.address, ss.price, sqfeet, storage, ss.availability from (commercial_unit c join Property p on (p.pr_id = c.pr_id)), person pp, sale_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from sale_unit);", conn);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
                
            }else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT c.pr_ID, name, p.address, ss.price, bhk, furnished, ss.availability from (residential_unit c join Property p on (p.pr_id = c.pr_id)), person pp, sale_unit ss where c.pr_id = ss.pr_id and pp.p_ID = owner_ID and c.pr_ID in (select pr_ID from sale_unit);", conn);
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
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
            String selected = "h";
            rental r1 = new rental(selected, sess);
            r1.Show();
            this.Hide();
        }

        private void flatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Commercial
            String selected = "c";
            rental r1 = new rental(selected, sess);
            r1.Show();
            this.Hide();
        }

        private void apartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //resendential
            String selected = "h";
            Sale r1 = new Sale(selected, sess);
            r1.Show();
            this.Hide();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //commercial
            String selected = "c";
            Sale r1 = new Sale(selected, sess);
            r1.Show();
            this.Hide();
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            } */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");
            SqlDataAdapter sda11 = new SqlDataAdapter("select property.pr_id, property.address, residential_unit.bhk  from residential_unit join property on (Property.pr_id = residential_unit.pr_id) where furnished like 'yes%';", conn);
            sda11.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];


            //System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");
            /*SqlCommand mycmd = conn.CreateCommand();
            mycmd.CommandText = "Execute getFurnished1";
            mycmd.CommandType=CommandType.StoredProcedure;
            try
            {

                conn.Open();
                //mycmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(mycmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception exc) { }
        */



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    
