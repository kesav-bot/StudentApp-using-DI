using Microsoft.AspNetCore.Mvc;
using StudentApp.Services;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        // 👇 Dependency Injection via constructor
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: /Student/
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        // GET: /Student/Details/2
        public IActionResult Details(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}
