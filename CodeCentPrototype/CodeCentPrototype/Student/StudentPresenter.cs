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
        //Tab indices used for tab change listener
        const int PROFILE_TAB_INDEX = 0;
        const int DETAILS_TAB_INDEX = 1;
        const int GRADES_TAB_INDEX = 2;
        const int ATTACHMENTS_TAB_INDEX = 3;

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
                //This fails EVERY time right now (2011-2012 does not parse to int). We're not actually filtering based off year yet.
                //Also, since we had to update to school years (2011-2012 instead of just 2011), we'll need to 
                //Split at the '-', and retrieve students who were "lastActive" during either year.
            }

            if (dbConn.Open())
            {
                DataTable info = dbConn.executeQuery("StudentInfo", null, null);
                DataTable grades = dbConn.executeQuery("grades", null, null);
                DataTable stats = dbConn.executeQuery("StudentStats", null, null);


                /*TESTING
                foreach (DataRow myField in grades.Rows)
                    foreach (DataColumn myProperty in grades.Columns)
                    {
                       // string title = myField[myProperty].ToString();
                       // if (myProperty.ColumnName == "ColumnName" && title.StartsWith("c_"))
                       // {
                        //    string dept = Regex.Replace(title, @"\d", "").Substring(COURSE_PREFIX_LENGTH);

                      //      Regex numbers = new Regex("[0-9]+");
                      //      int number = 0;
                     //       try
                      //      {
                      //          number = Int32.Parse(numbers.Match(title).Value);
                      //      }
                       //     catch (Exception e)
                       //     {
                         //       MessageBox.Show(myField[myProperty].ToString());
                       //         throw;
                       //     }

                       //     courses.Add(new Course(dept, number));
                       // }
                    }
                *///TESTING

                dbConn.Close();

                /*
                 * Relying on all tables to return the same number of rows - FIXME?
                 */
                try
                {
                    for (int i = 0; i < info.Rows.Count; i++)
                    {
                        StudentList.Add(new Student(info.Rows[i], stats.Rows[i], grades.Rows[i]));
                    }
                }
                catch (Exception) { }

                StudentList.Sort(delegate(Student s1, Student s2) { return s1.LastName.CompareTo(s2.LastName); });
                windowRef.listStudents.ItemsSource = StudentList;
                windowRef.listStudents.DisplayMemberPath = "DisplayString";
            }

        }

        public void selectedStudentChanged(object sender, SelectionChangedEventArgs e)
        {
            //Populate selected tab
            this.SelectedStudent = windowRef.listStudents.SelectedItem as Student;
            this.ProfileTabChanged(sender, e);
        }

        public void ProfileTabChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = windowRef.ProfileTabControl.SelectedIndex;

            if (windowRef.ProfileTabControl.SelectedIndex == PROFILE_TAB_INDEX)
                PopulateProfileTab();

            else if (windowRef.ProfileTabControl.SelectedIndex == DETAILS_TAB_INDEX)
                PopulateDetailsTab();

            else if (windowRef.ProfileTabControl.SelectedIndex == GRADES_TAB_INDEX)
                PopulateCourseGradesTab();

            else if (windowRef.ProfileTabControl.SelectedIndex == ATTACHMENTS_TAB_INDEX)
                PopulateAttachmentsTab();
        }


        public void PopulateProfileTab()
        {
            windowRef.textFirstName.Text = SelectedStudent.FirstName ?? "";
            windowRef.textLastName.Text = SelectedStudent.LastName ?? "";
            windowRef.textCellPhone.Text = SelectedStudent.CellPhone ?? "";
            windowRef.textHomePhone.Text = SelectedStudent.HomePhone ?? "";
            windowRef.textMiddleInitial.Text = SelectedStudent.MiddleInitial ?? "";
            try { windowRef.textStudentID.Text = SelectedStudent.StudentID.ToString(); } catch { }
            windowRef.textAddress.Text = SelectedStudent.StreetAddress ?? "";
            windowRef.textCity.Text = SelectedStudent.City ?? "";
            windowRef.textState.Text = SelectedStudent.State ?? "";
            try { windowRef.textZIPCode.Text = SelectedStudent.Zip.ToString(); } catch { }
            windowRef.textCWUEmailAddress.Text = SelectedStudent.CWUEmail ?? "";
            windowRef.textEmailAddress.Text = SelectedStudent.StandardEmail ?? "";
            windowRef.textBirthday.Text = SelectedStudent.Birthday ?? "";
        }

        public void PopulateDetailsTab()
        {
            windowRef.comboClassStanding.Text = SelectedStudent.Standing ?? "";
            try { windowRef.comboCWUAppStatus.Text = SelectedStudent.AppStatus.ToString(); } catch { }
            try { windowRef.comboTransfer.Text = SelectedStudent.Transfer.ToString(); } catch { }
            try { windowRef.textDateReceived.Text = SelectedStudent.DateReceived.Substring(0, SelectedStudent.DateReceived.IndexOf(" ")) ?? ""; } catch { };
            windowRef.textDateOfDirectorAction.Text = SelectedStudent.DirectorActionDate ?? "";
            windowRef.textQuarterEnteredCWU.Text = SelectedStudent.QuarterEnteredCWU ?? "";
            windowRef.textQuarterEnteredDHC.Text = SelectedStudent.QuarterEnteredDHC ?? "";
            try { windowRef.comboCurrentCWUStudent.Text = SelectedStudent.CurrentCWU.ToString(); } catch { }
        }

        public void PopulateCourseGradesTab()
        {
            /* Not implementing yet - need to have UI dynamically add labels and comboboxes (or some other control) for courses.
                        CourseHandler c = new CourseHandler();
                        List<Course> x = c.GetCourses();
                        string y = "";
                        foreach (Course a in x)
                            y += (a.DeptartmentCode + a.CourseNumber + "\n");
                        MessageBox.Show(y);
            */
            //Course Grades tab (grades) - FIXME: once CourseHandler is being used we'll just loop through List<Course> and dynamically populate UI.

            windowRef.combo140.Text = SelectedStudent.dhc140 ?? "";
            windowRef.combo141.Text = SelectedStudent.dhc141 ?? "";
            windowRef.combo150.Text = SelectedStudent.dhc150 ?? "";
            windowRef.combo151.Text = SelectedStudent.dhc151 ?? "";
            windowRef.combo160.Text = SelectedStudent.dhc160 ?? "";
            windowRef.combo161.Text = SelectedStudent.dhc161 ?? "";
            windowRef.combo250.Text = SelectedStudent.dhc250 ?? "";
            windowRef.combo251.Text = SelectedStudent.dhc251 ?? "";
            windowRef.combo260.Text = SelectedStudent.dhc260 ?? "";
            windowRef.combo261.Text = SelectedStudent.dhc261 ?? "";
            windowRef.combo270.Text = SelectedStudent.dhc270 ?? "";
            windowRef.combo301.Text = SelectedStudent.dhc301 ?? "";
            windowRef.combo380.Text = SelectedStudent.dhc380 ?? "";
            windowRef.combo399.Text = SelectedStudent.dhc399 ?? "";
            windowRef.combo401.Text = SelectedStudent.dhc401 ?? "";
            windowRef.combo497.Text = SelectedStudent.dhc497 ?? "";

            windowRef.comboSHP399.Text = SelectedStudent.shp399 ?? "";
            windowRef.comboSHP401.Text = SelectedStudent.shp401 ?? "";
            windowRef.comboSHP497.Text = SelectedStudent.shp497 ?? "";

            try { windowRef.textSAT.Text = SelectedStudent.Sat.ToString(); } catch { }
            try { windowRef.textACT.Text = SelectedStudent.Act.ToString(); } catch { }
            try { windowRef.textAI.Text = SelectedStudent.Ai.ToString(); } catch { }

            try { windowRef.textPriorQuarterGPA.Text = SelectedStudent.PriorGPA.ToString(); } catch { }
            try { windowRef.textCumulativeGPA.Text = SelectedStudent.CumGPA.ToString(); } catch { }
        }

        public void PopulateAttachmentsTab()
        {
            windowRef.textComments.Text = SelectedStudent.Notes ?? "";
            //Load attachment list here once we have that functionality
        }
    }
}
