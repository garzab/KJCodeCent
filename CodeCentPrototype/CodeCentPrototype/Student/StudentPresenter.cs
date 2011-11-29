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
                DataTable info = dbConn.executeQuery("StudentInfo", null, null);
                DataTable grades = dbConn.executeQuery("grades", null, null);
                DataTable stats = dbConn.executeQuery("StudentStats", null, null);

                dbConn.Close();

                /*
                 * Relying on all tables to return the same number of rows - FIXME?
                 */
                for (int i = 0; i < info.Rows.Count; i++)
                {
                    StudentList.Add(new Student(info.Rows[i], stats.Rows[i], grades.Rows[i]));
                }


                windowRef.listStudents.ItemsSource = StudentList;
                windowRef.listStudents.DisplayMemberPath = "DisplayString";
            }

        }

        public void selectedStudentChanged(object sender, SelectionChangedEventArgs e)
        {
            //Profile and attachments tabs
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

            //Details tabs (stats) - UNFINISHED (combobox possible values => db constraints)
            windowRef.comboClassStanding.Text = SelectedStudent.Standing.ToString();
            windowRef.comboCWUAppStatus.Text = SelectedStudent.AppStatus.ToString();
            windowRef.comboTransfer.Text = SelectedStudent.Transfer.ToString();
            windowRef.textDateReceived.Text = SelectedStudent.DateReceived;
            windowRef.textDateOfDirectorAction.Text = SelectedStudent.DirectorActionDate;
            windowRef.textQuarterEnteredCWU.Text = SelectedStudent.QuarterEnteredCWU;
            windowRef.textQuarterEnteredDHC.Text = SelectedStudent.QuarterEnteredDHC;
            windowRef.comboCurrentCWUStudent.Text = SelectedStudent.CurrentCWU.ToString();
            windowRef.comboCoreOrHybrid.Text = SelectedStudent.CoreHybrid;

            //Course Grades tab (grades) - FIXME: once CourseHandler is being used we'll just loop through List<Course> and dynamically populate UI.
            windowRef.combo140.Text = SelectedStudent.dhc140;
            windowRef.combo141.Text = SelectedStudent.dhc141;
            windowRef.combo150.Text = SelectedStudent.dhc150;
            windowRef.combo151.Text = SelectedStudent.dhc151;
            windowRef.combo160.Text = SelectedStudent.dhc160;
            windowRef.combo161.Text = SelectedStudent.dhc161;
            windowRef.combo250.Text = SelectedStudent.dhc250;
            windowRef.combo251.Text = SelectedStudent.dhc251;
            windowRef.combo260.Text = SelectedStudent.dhc260;
            windowRef.combo261.Text = SelectedStudent.dhc261;
            windowRef.combo270.Text = SelectedStudent.dhc270;
            windowRef.combo301.Text = SelectedStudent.dhc301;
            windowRef.combo380.Text = SelectedStudent.dhc380;
            windowRef.combo399.Text = SelectedStudent.dhc399;
            windowRef.combo401.Text = SelectedStudent.dhc401;
            windowRef.combo497.Text = SelectedStudent.dhc497;

            windowRef.comboSHP399.Text = SelectedStudent.shp399;
            windowRef.comboSHP401.Text = SelectedStudent.shp401;
            windowRef.comboSHP497.Text = SelectedStudent.shp497;

            windowRef.textSAT.Text = SelectedStudent.Sat.ToString();
            windowRef.textACT.Text = SelectedStudent.Act.ToString();
            windowRef.textAI.Text = SelectedStudent.Ai.ToString();

            windowRef.textPriorQuarterGPA.Text = SelectedStudent.PriorGPA.ToString();
            windowRef.textCumulativeGPA.Text = SelectedStudent.CumGPA.ToString();

        }



        // TO DO: Add presentation logic
    }
}
