using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Kyla Gaiser", StudentId = "21-2205", StudentAge = "20" },
            new StudentInfoModel { Name = "Nj Ferrer", StudentId = "21-2206", StudentAge = "21" },
            new StudentInfoModel { Name = "Kurt Delos Santos", StudentId = "21-2207", StudentAge = "22" },
            new StudentInfoModel { Name = "Trisha", StudentId = "21-2208", StudentAge = "23" }
            new StudentInfoModel { Name = "Aldrian Bersamina", StudentId = "21-2208", StudentAge = "24" }
        };

        return View(studentInfoArray);
    }
}
