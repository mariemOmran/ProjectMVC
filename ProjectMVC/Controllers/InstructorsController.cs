using Microsoft.AspNetCore.Mvc;
using ProjectMVC.Models;

namespace ProjectMVC_Products.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult All()
        {
            InstructorBL ins = new InstructorBL();
            List<Instructor> Instructor = ins.GetAll();
            return View("All", Instructor);
        }
        public IActionResult Details(int id)
        {
            InstructorBL ins = new InstructorBL();
            Instructor Instructor = ins.GetByID(id);
            return View("Details", Instructor);
        }
    }
}
