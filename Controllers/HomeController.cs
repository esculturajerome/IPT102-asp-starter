using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Kert Delos Santos", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Karl Delos Santos", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Kyle Delos Santos", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
