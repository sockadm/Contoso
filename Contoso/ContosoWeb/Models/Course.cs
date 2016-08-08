using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoWeb.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // permite que crie a chave primaria no lugar da auto-geração.
        public int CourseID { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Credits")]
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}