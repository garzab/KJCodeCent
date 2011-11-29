using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;



using System.Windows.Controls;
using System.Windows;
using System.Data;

namespace CodeCentPrototype
{
    public class CourseHandler
    {
        private DBController dbConn;

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            dbConn = new DBController();

            DataTable grades = null;
            if (dbConn.Open())
            {
                grades = dbConn.GetSchema("Grades");
            }

            dbConn.Close();

            if (grades != null)
                foreach (DataRow myField in grades.Rows)
                    foreach (DataColumn myProperty in grades.Columns)
                    {
                        string title = myField[myProperty].ToString();
                        if (myProperty.ColumnName == "ColumnName" && title.StartsWith("c_"))
                        {
                            string dept = Regex.Replace(title, @"\d", "").Substring(2);

                            Regex numbers = new Regex("[0-9]+");
                            int number = 0;
                            try
                            {
                                number = Int32.Parse(numbers.Match(title).Value);
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Error parsing Grade schema for course list: " + e.Message);
                                throw;
                            }
                                                        
                            courses.Add(new Course(dept, number));
                        }
                    }
            return courses;
        }

        public int AddCourse()
        {
            return 0; // FIXME
        }

    }
}
