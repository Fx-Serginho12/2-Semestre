using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace _19_Atividade_CRUD.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
