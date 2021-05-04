using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MetroRail_Ticketing
{
    public partial class CancelDash : Form
    {
        public CancelDash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDb();


            string PHONE = p_phone.Text;
            string DATE = journeydate.Text;
            try
            {
                if (PHONE.Length != 0 && DATE.Length != 0)
                {
                    conn.Open();
                    string query = string.Format("Delete from Passenger where Phone='{0}'and Date_of_journey='{1}'", PHONE, DATE);
                    SqlCommand cmd = new SqlCommand(query, conn);
                   int r = cmd.ExecuteNonQuery();
                    //MessageBox.Show("Ticket has been cancelled successfully");
                    if (r > 0)
                    {
                        MessageBox.Show("Ticket has been cancelled successfully");
                    }
                    else
                    {
                        MessageBox.Show("not found");
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Failed");

                }
            }

            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void CancelDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GO_BACk(object sender, EventArgs e)
        {
            this.Hide();
            new Option().Show();
        }
    }
}
