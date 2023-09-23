using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Kyla Gaiser", StudentId = "21-2205", StudentAge = "20" },
            new StudentInfoModel { Name = "Nj Ferrer", StudentId = "21-2206", StudentAge = "22" },
            new StudentInfoModel { Name = "Mary Joy", StudentId = "21-2207", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
