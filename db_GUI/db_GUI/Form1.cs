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
namespace db_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string c_code = tbCCode.Text;
            string c_name = tbCName.Text;

            string connString = @"server=DESKTOP-HTEH6GT\SQLEXPRESS;Database=course;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("insert into courses values('{0}','{1}')", c_code, c_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Could not Insert data");
            }
            conn.Close();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var list = GetCourses();
            dtCourses.DataSource = list;
         }

        private List<Course> GetCourses()
        {
            string connString = @"server=DESKTOP-HTEH6GT\SQLEXPRESS;Database=course;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "select * from courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //ArrayList list = new ArrayList();
            List<Course> list = new List<Course>();
            while (reader.Read())
            {
                Course c = new Course();

                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));

                list.Add(c);

            }

            //dtCourses.DataSource = list;
            conn.Close();
            return list;

        }

        private void LoadData(object sender, EventArgs e)
        {
            var list = GetCourses();
            dtCourses.DataSource = list;
        }





    }
}

    



