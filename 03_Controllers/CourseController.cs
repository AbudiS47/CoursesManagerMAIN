using CourseManagementMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementMVC.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var list = _context.Courses.ToList();
            return View(list);

        }
    }
}
