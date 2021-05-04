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
    public partial class PassengerDetails : Form
    {
        public PassengerDetails()
        {
            InitializeComponent();
        }

        private void search_click(object sender, EventArgs e)
        {
            if (p_phone_details.Text.Length == 11 )
            {
                var alist = GetPASSENGERS();
                dt_Dtails.DataSource = alist;
            }
            else
            {
                MessageBox.Show("Passenger is not found,please insert the correct name and phone number ");
            }
        }
        private List<PASSENGER> GetPASSENGERS()
        {
            var conn = Database.ConnectDb();
            conn.Open();
            string Pass_Name = pname_details.Text;
            string Pass_Phone = p_phone_details.Text;
            string query = string.Format("Select * from Passenger where Name='{0}' and Phone='{1}'", Pass_Name, Pass_Phone);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<PASSENGER> plist = new List<PASSENGER>();
            while (reader.Read())
            {
                PASSENGER P = new PASSENGER();
                P.ID = reader.GetInt32(reader.GetOrdinal("Id"));
                P.NAME = reader.GetString(reader.GetOrdinal("Name"));
                P.PHONE = reader.GetString(reader.GetOrdinal("Phone"));
                P.GENDER = reader.GetString(reader.GetOrdinal("Gender"));
                P.FROM = reader.GetString(reader.GetOrdinal("Journey_from"));
                P.TO = reader.GetString(reader.GetOrdinal("Destination"));
                P.DateofJourney = reader.GetString(reader.GetOrdinal("Date_of_journey"));
                P.TRAINTIME = reader.GetString(reader.GetOrdinal("Train_Time"));

                plist.Add(P);
            }
            conn.Close();
            return plist;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var conn = Database.ConnectDb();
            conn.Open();
            
            string query = "select * from Passenger";
            SqlDataAdapter D = new SqlDataAdapter(query, conn);
            DataTable A = new DataTable();
            D.Fill(A);
            dt_Dtails.DataSource = A;


            conn.Close();
        }

        

        private void GO_BACK(object sender, EventArgs e)
        {
            this.Hide();
            new Option().Show();
        }

        private void PassengerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
