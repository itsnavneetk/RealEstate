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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        System.Data.SqlClient.SqlConnection conn = new SqlConnection(@"Data Source =.; Initial Catalog = realestate; Integrated Security = TrueData Source=.;Initial Catalog=realestate;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            String name = textBox1.Text;
            String phone = textBox2.Text;
            String email = textBox4.Text;
            String address = textBox6.Text;
            String username = textBox5.Text;
            String password = textBox7.Text;

            // MessageBox.Show(""+name + phone + email+address + username + password);
            if (name != null && phone != null && email != null && address != null && username != null && password != null)
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO PERSON (name, address, email, phone) values ('" + name + "','" + address + "','" + email + "','" + phone + "')", conn);
                sda.SelectCommand.ExecuteNonQuery();


                SqlDataAdapter sda1 = new SqlDataAdapter("INSERT INTO login (p_id, username, password) values (52, '" + username + "','" + password + "')", conn);
                sda1.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("successfully entered!");
                login l = new login();

                conn.Close();
                l.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("please enter all values");
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
