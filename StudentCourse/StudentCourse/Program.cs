using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Course A = new Course("OOP", "C1122", "CSE");
            Course B = new Course("OOP2", "C1123", "CSE");
            Course C = new Course("DLC", "E0001", "EEE");
            Course D = new Course("ACCOUNTING", "B3301", "Buisness");
            Course E = new Course("Numerical Method", "M2004", "Mathmatics");

            Student x = new Student("diya", "18-38282-2", "3-02-2000", 3.76f, 98);
            Student y = new Student("momo", "18-38255-3", "9-02-1999", 3.70f, 100);
            Student z = new Student("Zannat", "18-38302-2", "23-09-1999", 3.80f, 102);
            Student p = new Student("fahmi", "18-3800-1", "12-12-2001", 3.56f, 90);

            x.AddingCourse(A, B, C, D, E);

            x.DelCourse(B);



            //y.AddingCourse(B, D, E);

            // z.AddingCourse(A, C, D);
            //z.DelCourse(C);


            A.CountStudent(x, y, z, p);
            B.CountStudent(x, y);
            C.CountStudent(z, p);
            D.CountStudent(x, z, y);
            E.CountStudent(y);

            x.Show();
            
            C.StudentInfo();
            E.StudentInfo();

        }
    }
    }

