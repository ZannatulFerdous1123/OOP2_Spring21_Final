using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MetroRail_Ticketing
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee(object sender, EventArgs e)
        {
            var conn = Database.ConnectDb();
            string name = e_name.Text;

            string age = e_age.Text;
            string gender;
            string username = e_username.Text;
            string password = e_password.Text;

            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {

                gender = "Female";

            }
            else
            {
                gender = "Others";
            }

           if(name.Length!=0 && age.Length != 0 && gender.Length != 0 && username.Length != 0 && password.Length != 0)
            {
                conn.Open();


                string query = string.Format("insert into Employee values ('{0}','{1}','{2}','{3}','{4}')", name, username, password, age, gender);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("New Employee added Successfully");

                }
                else
                {
                    MessageBox.Show("Insertion is failed");
                }
                conn.Close();

           }
            else
            {
                MessageBox.Show("Insertion is failed!Field can not be Empty");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GO_BACK(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
