using FERRER_IPT102.Models;
using Microsoft.AspNetCore.Mvc;

namespace FERRER_IPT102.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            var StudentInfoArray = new[]
            {
            new StudentInfo { StudentName = "SpongeBob Squarepants", QCUStudentID = "23-001", QCUStudentAge = "25" },
            new StudentInfo { StudentName = "Patrick Star", QCUStudentID = "23-002", QCUStudentAge = "26" },
            new StudentInfo { StudentName = "Jennie Kim", QCUStudentID = "23-003", QCUStudentAge = "27" },
            new StudentInfo { StudentName = "Lalisa Manoban", QCUStudentID = "23-004", QCUStudentAge = "19" },
            new StudentInfo { StudentName = "Jisoo Kim", QCUStudentID = "23-005", QCUStudentAge = "18" },
            new StudentInfo { StudentName = "Roseanne Park", QCUStudentID = "23-021", QCUStudentAge = "19" },
            new StudentInfo { StudentName = "Joy Lambingin", QCUStudentID = "23-022", QCUStudentAge = "20" },
            new StudentInfo { StudentName = "Don Macchiatto", QCUStudentID = "23-023", QCUStudentAge = "21" },
            new StudentInfo { StudentName = "Johnson Pawer", QCUStudentID = "23-024", QCUStudentAge = "23" },
             new StudentInfo { StudentName = "Zhao Lusi", QCUStudentID = "23-025", QCUStudentAge = "24" }
        };

            return View(StudentInfoArray);
        }
    }
}

