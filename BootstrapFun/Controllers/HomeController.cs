using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapFun.Models;

namespace BootstrapFun.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }

}