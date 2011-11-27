using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CodeCentPrototype
{
    public class Student
    {
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

        public string DisplayString { get; protected set; }



        public string ClassStanding { get; protected set; }
        public string EnrollmentStatus { get; protected set; }
        public string ProgramType { get; protected set; }
        public List<string> AssociatedFiles { get; protected set; }


        /// <summary>
        /// Contstructs student record based off output from the database. Only working for StudentInfo table right now (we'll need to add the others)
        /// </summary>
        /// <param name="row">Row from StudentInfo table. Expand on this later for other tables as well</param>
        public Student(DataRow row)
        {
            object[] items = row.ItemArray;

            this.StudentID = (int)items.ElementAt(0);                //Try catch
            this.FirstName = items.ElementAt(2).ToString();
            this.MiddleInitial = items.ElementAt(3).ToString();
            this.LastName = items.ElementAt(4).ToString();
            this.Birthday = items.ElementAt(5).ToString();
            this.StreetAddress = items.ElementAt(6).ToString();
            this.City = items.ElementAt(7).ToString();
            this.State = items.ElementAt(8).ToString();            
            this.Zip = (int)items.ElementAt(9);                      //Try catch
            this.HomePhone = items.ElementAt(10).ToString();
            this.CellPhone = items.ElementAt(11).ToString();
            this.StandardEmail = items.ElementAt(12).ToString();
            this.CWUEmail = items.ElementAt(13).ToString();
            this.Notes = items.ElementAt(14).ToString();

            this.DisplayString = LastName + ", " + FirstName;
        }


       // public abstract int ArchiveStudent();

       // public abstract int UpdateInformation();

    }
}
