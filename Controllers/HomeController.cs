using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jhustine Bonso", StudentId = "21-1767", StudentAge = "21" },
            new StudentInfoModel { Name = "Willia Bonso", StudentId = "21-0989", StudentAge = "60" },
            new StudentInfoModel { Name = "Eduardo Bonso", StudentId = "21-0990", StudentAge = "61" }
        };

        return View(studentInfoArray);
    }
}
