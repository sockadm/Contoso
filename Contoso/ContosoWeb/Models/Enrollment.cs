using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoWeb.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } // o ? significa que a classe pode ser nullable.

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}