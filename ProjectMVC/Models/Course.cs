using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public int Degree { get; set; }
        public int Min_Degree { get; set; }
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
