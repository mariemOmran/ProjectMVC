using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class DBProjectContext:DbContext
    {
        public DBProjectContext() : base() { }
        //Class MApping Table
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<courseResult> CorsRes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Data Source=.;Initial Catalog=DB_Project_MVC;Integrated Security=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
