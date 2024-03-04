namespace ProjectMVC.Models
{
    public class CourseBl
    {
        DBProjectContext db ;
        List<Course> courses;
       public CourseBl() {
            db = new DBProjectContext();
            courses = db.Courses.ToList();
        }
        public List<Course> GetAll() { 
        return courses;
        }
        
    }
}
