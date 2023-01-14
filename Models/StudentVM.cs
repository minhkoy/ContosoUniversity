using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class StudentVM
    {
        public int ID { get; set; }
        [Display(Name = "Last name")] public string LastName { get; set; }

        [Display(Name = "First & Middle name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Enrollment Date")] public DateTime EnrollmentDate { get; set; }
    }
}