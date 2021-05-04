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
    public partial class Passengers : Form
    {
        public Passengers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addticket(object sender, EventArgs e)
        {
            var conn = Database.ConnectDb();
            string name = p_name.Text;
            string phone = p_mob.Text;
            string gender;
            string From =from.Text;
            string Destination = destination.Text;
            string Dateofjourney = Date.Text;
            string TrainTime = time.Text;

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

            if (name.Length != 0 && phone.Length == 11 && gender.Length != 0 && From.Length != 0 && Destination.Length != 0 && Dateofjourney.Length != 0 && TrainTime.Length != 0 && Destination != From)
            {
               
                    conn.Open();
                    string query = string.Format("insert into Passenger values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", name, phone, gender, From, Destination, Dateofjourney, TrainTime);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Ticket has been  booked ");
                    }
                    else
                    {
                        MessageBox.Show("Booking is failed");
                    }
                    conn.Close();


                
               
            }
            else
            {
                MessageBox.Show(" Failed!!");
            }
        }

        private void GO_BACK(object sender, EventArgs e)
        {
            this.Hide();
            new Option().Show();
        }

        private void Passengers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
