using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCentPrototype
{
    public class Course
    {
        public string DeptartmentCode { get; set; }
        public int CourseNumber { get; set; }
        public int Credits { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Course(string deptCode, int courseNumber/*, int credits, string title, string description*/)
        {
            this.DeptartmentCode = deptCode;
            this.CourseNumber = courseNumber;
            //this.Credits = credits;
            //this.Title = title;          /////////WHERE ARE WE STORING THIS?
            //this.Description = description;
        }

    }
}
