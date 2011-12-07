using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows;

namespace CodeCentPrototype
{
    public class CourseHandler
    {
        const string COURSE_PREFIX = "c_"; //In the Grades table, we prefix course columns with "c_", e.g. "c_CS480".

        private DBController dbConn;

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            dbConn = new DBController();

            DataTable grades = null;
            if (dbConn.Open())
            {
                grades = dbConn.GetSchema("Grades");
                dbConn.Close();
            }


            /*
            if (grades != null)
                foreach (DataRow myField in grades.Rows)
                    foreach (DataColumn myProperty in grades.Columns)
                    {
                        string title = myField[myProperty].ToString();
                        if (myProperty.ColumnName == "ColumnName" && title.StartsWith(COURSE_PREFIX))
                        {
                            string dept = Regex.Replace(title, @"\d", "").Substring(COURSE_PREFIX.Length);

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
                                                        
                            courses.Add(new Course(dept, number, ""));
                        }
                    }*/
            return courses;
        }

        public int AddCourse()
        {
            return 0; // FIXME
        }

    }
}
