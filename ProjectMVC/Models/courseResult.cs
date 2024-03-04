using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class courseResult
    {
        public int id { get; set; }
        public int Degree { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerID { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }

        public Trainer Trainer { get; set; }
        public Course Course { get; set; }
    }
}
