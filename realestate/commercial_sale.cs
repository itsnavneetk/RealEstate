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
    public partial class commercial_sale : Form
    {
        public int sess;
        public commercial_sale(int sess1)
        {
            sess = sess1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sess = 10;
            String address = textBox4.Text;
            String price = textBox1.Text;
            String sq = textBox2.Text;
            String storage = textBox3.Text;
            label5.Text = sess+"";
            // MessageBox.Show(""+name + phone + email+address + username + password);
            if (address != null && price!= null && sq!= null && storage!= null)
            {
                System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO commercial_unit (pr_id, sqfeet, storage) values ('23','" + sq  + "','" + storage + "')", conn);
                sda.SelectCommand.ExecuteNonQuery();

                SqlDataAdapter sda1 = new SqlDataAdapter("INSERT INTO property (owner_id, address) values ('"+ sess + "','" + address + "')", conn);
                sda1.SelectCommand.ExecuteNonQuery();

                SqlDataAdapter sda11 = new SqlDataAdapter("INSERT INTO sale_unit (pr_id, price) values ('23','" + price + "')", conn);
                sda11.SelectCommand.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("successfully entered!");


                Form1 l = new Form1();
                l.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please enter all values");
            }
        }
    }
}
