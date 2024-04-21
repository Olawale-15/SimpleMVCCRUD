using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();

        private static List<Student> loginStudent = new List<Student>();
        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Register()
        {
            Student student = new Student();
            return View(student);
        }

        public IActionResult RegisterStudent(Student student)
        {
            students.Add(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Login()
        {
            Student student = new Student();
            return View(student);
        }

        public IActionResult LoginStudent(Student student)
        {
            loginStudent.Add(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
