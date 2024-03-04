using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;
using ProjectMVC.ViewModel;

namespace ProjectMVC.Controllers
{
    public class TrainerController : Controller
    {
        DBProjectContext db;
       public TrainerController() {
            db = new DBProjectContext();
        }
        public IActionResult All() {
            AllTrainersAndAllCoursesAndCourseResultsViewModel tcR = new AllTrainersAndAllCoursesAndCourseResultsViewModel();
            return View("All", tcR);

        }
        public IActionResult showResult(int id,int courseID)
        {
           Trainer trainer =db.Trainers.FirstOrDefault(n => n.Id == id);
            Course course = db.Courses.FirstOrDefault(n => n.Id == courseID);
            courseResult result = db.CorsRes.FirstOrDefault(n => n.TrainerID == id && n.CourseID == courseID);

            HttpContext.Session.SetString("Name", trainer.Name);
            TrainerDataWithCourseDataViewModel vw = new TrainerDataWithCourseDataViewModel();
            vw.Grade = result.Degree;
            vw.TrainerName = trainer.Name;
            vw.CourseName = course.Name;
          

            if (vw.Grade < course.Min_Degree )
            {
                vw.color = "red";
            }
            else {
                vw.color = "green";
            }
            return View("showResult",vw);
        }
    }
}
