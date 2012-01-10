using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;


namespace CodeCentPrototype
{
    public class Student
    {
        //Name displayed in studentListbox
        public string DisplayString { get; protected set; }

        //From StudentInfo table
        public int StudentID { get; protected set; }
        public bool Archived { get; protected set; }
        public string FirstName { get; protected set; }
        public string MiddleInitial { get; protected set; }
        public string LastName { get; protected set; }
        public string Birthday { get; protected set; }
        public string StreetAddress { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public int Zip { get; protected set; }
        public string HomePhone { get; protected set; }
        public string CellPhone { get; protected set; }
        public string StandardEmail { get; protected set; }
        public string CWUEmail { get; protected set; }
        public string Notes { get; protected set; }
        //End StudentInfo table

        //From Grades table
        // GET RID OF THESE  only doing this for the presentation since our DB schema is still being finalized. 
        // Change to: List<Course>. In Student constructor, call CourseHandler with the Student ID. CourseHandler gets DataRow for student.
        // Foreach non-null course field, instantiate Course object with the column name (using Activator.CreateInstance Method or a Dictionary), and append to Course list. 
        // When all Courses and grades are added for the student, return the List. 
        public string dhc140 { get; protected set; }
        public string dhc141 { get; protected set; }
        public string dhc150 { get; protected set; }
        public string dhc151 { get; protected set; }
        public string dhc160 { get; protected set; }
        public string dhc161 { get; protected set; }
        public string dhc250 { get; protected set; }
        public string dhc251 { get; protected set; }
        public string dhc260 { get; protected set; }
        public string dhc261 { get; protected set; }
        public string dhc270 { get; protected set; }
        public string dhc301 { get; protected set; }
        public string dhc380 { get; protected set; }
        public string dhc399 { get; protected set; }
        public string dhc401 { get; protected set; }
        public string dhc497 { get; protected set; }

        public string shp399 { get; protected set; }
        public string shp401 { get; protected set; }
        public string shp497 { get; protected set; }

        public Decimal Sat{ get; protected set; }
        public Decimal Act { get; protected set; }
        public Decimal Ai { get; protected set; }
        
        public Decimal CollegeGPA { get; protected set; }
        public Decimal PriorGPA { get; protected set; }
        public Decimal CumGPA { get; protected set; }
        //End Grades table


        //From StudentStats table
        public string FirstYear { get; protected set; }
        public string AppStatus { get; protected set; }
        public bool CurrentCWU { get; protected set; }
        public string DateReceived { get; protected set; }
        public bool Transfer { get; protected set; }
        public string QuarterEnteredDHC { get; protected set; }
        public string QuarterEnteredCWU { get; protected set; }
        public string Status { get; protected set; }
        public string StatusDate { get; protected set; }
        public string DirectorAction { get; protected set; }
        public string DirectorActionDate { get; protected set; }
        public string CoreHybrid { get; protected set; }
        public string Standing { get; protected set; }
        //End StudentStats table

        //Where does this belong?
        public string ProgramType { get; protected set; }


        //Unimplemented
        //public List<string> AssociatedFiles { get; protected set; }


        /// <summary>
        /// Contstructs student record based off output from the database. Only working for StudentInfo table right now (we'll need to add the others)
        /// </summary>
        /// <param name="row">Row from StudentInfo table. Expand on this later for other tables as well</param>
        public Student(DataRow info, DataRow stats, DataRow grades)
        {
            object[] studentInfo = info.ItemArray;
            
            //Info
            try
            {
                this.StudentID = (int)studentInfo.ElementAt(0);                //Try catch
                this.FirstName = studentInfo.ElementAt(2).ToString();
                this.MiddleInitial = studentInfo.ElementAt(3).ToString();
                this.LastName = studentInfo.ElementAt(4).ToString();
                this.Birthday = studentInfo.ElementAt(5).ToString();
                this.StreetAddress = studentInfo.ElementAt(6).ToString();
                this.City = studentInfo.ElementAt(7).ToString();
                this.State = studentInfo.ElementAt(8).ToString();
                this.Zip = (int)studentInfo.ElementAt(9);                      //Try catch
                this.HomePhone = studentInfo.ElementAt(10).ToString();
                this.CellPhone = studentInfo.ElementAt(11).ToString();
                this.StandardEmail = studentInfo.ElementAt(12).ToString();
                this.CWUEmail = studentInfo.ElementAt(13).ToString();
                this.Notes = studentInfo.ElementAt(14).ToString();

                this.DisplayString = LastName + ", " + FirstName;


                //Stats
                object[] studentStats = stats.ItemArray;
                this.FirstYear = studentStats.ElementAt(1).ToString();
                this.AppStatus = studentStats.ElementAt(2).ToString();
                this.CurrentCWU = Boolean.Parse(studentStats.ElementAt(3).ToString());
                this.DateReceived = studentStats.ElementAt(4).ToString();
                this.Transfer = Boolean.Parse(studentStats.ElementAt(5).ToString());
                this.QuarterEnteredCWU = studentStats.ElementAt(6).ToString();
                this.QuarterEnteredDHC = studentStats.ElementAt(7).ToString();
                this.Status = studentStats.ElementAt(8).ToString();
                this.StatusDate = studentStats.ElementAt(8).ToString();
                this.DirectorAction = studentStats.ElementAt(9).ToString();
                this.DirectorActionDate = studentStats.ElementAt(10).ToString();
                this.CoreHybrid = studentStats.ElementAt(11).ToString();
                //CORE HYBRID????
                this.Standing = studentStats.ElementAt(13).ToString();

                //Grades
                object[] studentGrades = grades.ItemArray;
                this.dhc140 = studentGrades.ElementAt(1).ToString();
                this.dhc141 = studentGrades.ElementAt(2).ToString();
                this.dhc150 = studentGrades.ElementAt(3).ToString();
                this.dhc151 = studentGrades.ElementAt(4).ToString();
                this.dhc160 = studentGrades.ElementAt(5).ToString();
                this.dhc161 = studentGrades.ElementAt(6).ToString();
                this.dhc250 = studentGrades.ElementAt(7).ToString();
                this.dhc251 = studentGrades.ElementAt(8).ToString();
                this.dhc260 = studentGrades.ElementAt(9).ToString();
                this.dhc261 = studentGrades.ElementAt(10).ToString();
                this.dhc270 = studentGrades.ElementAt(11).ToString();
                this.dhc301 = studentGrades.ElementAt(12).ToString();
                this.dhc380 = studentGrades.ElementAt(13).ToString();
                this.dhc399 = studentGrades.ElementAt(14).ToString();
                this.dhc401 = studentGrades.ElementAt(15).ToString();
                this.dhc497 = studentGrades.ElementAt(16).ToString();
                this.shp399 = studentGrades.ElementAt(17).ToString();
                this.shp401 = studentGrades.ElementAt(18).ToString();
                this.shp497 = studentGrades.ElementAt(19).ToString();

                if (studentGrades.ElementAt(20).ToString() != "") this.Sat = Decimal.Parse(studentGrades.ElementAt(20).ToString());
                if (studentGrades.ElementAt(21).ToString() != "") this.Act = Decimal.Parse(studentGrades.ElementAt(21).ToString());
                if (studentGrades.ElementAt(22).ToString() != "") this.Ai = Decimal.Parse(studentGrades.ElementAt(22).ToString());

                if (studentGrades.ElementAt(23).ToString() != "") this.CollegeGPA = Decimal.Parse(studentGrades.ElementAt(23).ToString());
                if (studentGrades.ElementAt(24).ToString() != "") this.PriorGPA = Decimal.Parse(studentGrades.ElementAt(24).ToString());
                if (studentGrades.ElementAt(25).ToString() != "") this.CumGPA = Decimal.Parse(studentGrades.ElementAt(25).ToString());
            }
            catch (Exception)
            {
            }


        }

        public Student() {  }

        // public abstract int ArchiveStudent();

        // public abstract int UpdateInformation();

    }
}
