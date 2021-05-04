using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroRail_Ticketing
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void BookTicket(object sender, EventArgs e)
        {
            this.Hide();
            new Passengers().Show();
        }

        private void CancelTicket(object sender, EventArgs e)
        {
            this.Hide();
            new CancelDash().Show();
        }

        private void GetDetails(object sender, EventArgs e)
        {
            this.Hide();
            new PassengerDetails().Show();
        }

        private void Log_out(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
