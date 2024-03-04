using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class InstructorBL
    {
        public DBProjectContext ITIContext ;
        public List<Instructor> InstructorsModel;
        public InstructorBL()
        {
            ITIContext = new DBProjectContext();
            InstructorsModel = ITIContext.Instructors.Include(n => n.Department).ToList();
        }
        public List<Instructor> GetAll()
        {
            return InstructorsModel;
        }
        public Instructor GetByID(int ID)
        {
            return InstructorsModel.FirstOrDefault(n => n.Id == ID);
        }

    }
}
