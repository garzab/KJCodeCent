using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Data;



namespace CodeCentPrototype
{

    // This class acts as presenter for student information - receives events from UI, populates correct UI fields what a selected student 
    public class StudentPresenter
    {
        private MainWindow windowRef;
        private DBController dbConn;
        private List<Student> StudentList;
        private Student SelectedStudent;


        public StudentPresenter(MainWindow reference)
        {
            windowRef = reference;
            dbConn = new DBController();
            StudentList = new List<Student>();
        }

        //Currently getting ALL students. This will need to filter by school year.
        public void SelectedYearChanged(object sender, SelectionChangedEventArgs e)
        {
            int year;
            try
            {
                ComboBoxItem cb = (ComboBoxItem)windowRef.comboYear.SelectedItem;
                year = Int32.Parse(cb.Content.ToString());
            }
            catch (Exception)
            {
                //This fails EVERY time right now. We're not actually filtering based off year yet.
                //Also, since we had to update to school years (2011-2012 instead of just 2011), we'll need to 
                //Split at the '-', and retrieve students who were "lastActive" during either year.
            }

            if (dbConn.Open())
            {
                DataTable studentInfo = dbConn.executeQuery("StudentInfo", null, null);

                dbConn.Close();

                /*
                 * This is only temporary! Need basic UI functionality for midterm presentation
                 */
                for (int i = 0; i < studentInfo.Rows.Count; i++)
                {
                    StudentList.Add(new Student(studentInfo.Rows[i]));
                }


                windowRef.listStudents.ItemsSource = StudentList;
                windowRef.listStudents.DisplayMemberPath = "DisplayString";
            }

        }

        public void selectedStudentChanged(object sender, SelectionChangedEventArgs e)
        {

            SelectedStudent = windowRef.listStudents.SelectedItem as Student;
            windowRef.textFirstName.Text = SelectedStudent.FirstName;
            windowRef.textLastName.Text = SelectedStudent.LastName;
            windowRef.textCellPhone.Text = SelectedStudent.CellPhone;
            windowRef.textHomePhone.Text = SelectedStudent.HomePhone;
            windowRef.textMiddleInitial.Text = SelectedStudent.MiddleInitial;
            windowRef.textStudentID.Text = SelectedStudent.StudentID.ToString();
            windowRef.textAddress.Text = SelectedStudent.StreetAddress;
            windowRef.textCity.Text = SelectedStudent.City;
            windowRef.textZIPCode.Text = SelectedStudent.Zip.ToString();
            windowRef.textCWUEmailAddress.Text = SelectedStudent.CWUEmail;
            windowRef.textEmailAddress.Text = SelectedStudent.StandardEmail;
            windowRef.textBirthday.Text = SelectedStudent.Birthday;
            windowRef.textComments.Text = SelectedStudent.Notes;


        }



        // TO DO: Add presentation logic
    }
}
