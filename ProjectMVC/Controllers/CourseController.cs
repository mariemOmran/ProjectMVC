using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.ProjectModel;
using ProjectMVC.Models;
using ProjectMVC.ViewModel;

namespace ProjectMVC.Controllers
{
    public class CourseController : Controller
    {
        CourseBl CourseBl = new CourseBl();
        public IActionResult All()
        {
            return View("All", CourseBl.GetAll());
        }
        public IActionResult ShowCourseResults(int id)
        {
            List<AllTrainersAndAllCoursesAndCourseResultsViewModel> TCD = new List<AllTrainersAndAllCoursesAndCourseResultsViewModel>();
           DBProjectContext db = new DBProjectContext();

            List<courseResult> crsTrainer = new List<courseResult>();

            //crsTrainer = db.CorsRes.Where(n=>n.CourseID == id).ToList();
            crsTrainer = db.CorsRes.Where(n => n.CourseID == id)
               .Include(n => n.Trainer)
               .Include(n => n.Course).ToList();
            int i = 0;
            foreach (courseResult item in crsTrainer) {
            AllTrainersAndAllCoursesAndCourseResultsViewModel obj = new AllTrainersAndAllCoursesAndCourseResultsViewModel();
                obj.id = i++;
                obj.NameTrainer = item.Trainer.Name;
                obj.imageTrainer = item.Trainer.Image;
                obj.DegreeTrainer = item.Degree;
                obj.NameCourse = item.Course.Name;
                obj.MinDegree = item.Course.Min_Degree;
                if (item.Degree < item.Course.Min_Degree)
                {
                    obj.Color = "red";
                }
                else {
                    obj.Color = "green";
                }
                TCD.Add(obj);
            }
            


            return View("ShowCourseResults", TCD);
        }
    }
}
