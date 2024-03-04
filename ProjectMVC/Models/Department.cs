using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Manager { get; set; }
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
