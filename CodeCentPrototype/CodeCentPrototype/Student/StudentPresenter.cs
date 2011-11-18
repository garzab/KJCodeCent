using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCentPrototype
{

    // This class acts as presenter for student information - receives events from UI, populates correct UI fields what a selected student 
    public class StudentPresenter
    {
        private List<Student> students;

        public List<Student> GetStudentsForYear(int year)
        {
            return new List<Student>(); // FIXME
        }

        // TO DO: Add presentation logic
    }
}
