using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCentPrototype
{
    public abstract class Student
    {
        public int StudentID { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string StreetAddress { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public int Zip { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public string EmailAddress { get; protected set; }
        public string ClassStanding { get; protected set; }
        public string EnrollmentStatus { get; protected set; }
        public string ProgramType { get; protected set; }
        public List<string> AssociatedFiles { get; protected set; }


        public abstract int ArchiveStudent();

        public abstract int UpdateInformation();

    }
}
