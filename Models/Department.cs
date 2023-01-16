using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)] public string Name { get; set; }

        [DataType(DataType.Currency)]
        //This case: the Column attribute is used to change SQL data type mapping.
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        //Foreign key
        [Display(Name = "Instructor")] public int? InstructorID { get; set; }

        //Navigation property
        public Instructor Administrator { get; set; } //Admin is also an instructor
        public ICollection<Course> Courses { get; set; }
    }
}