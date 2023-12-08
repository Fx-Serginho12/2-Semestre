using System.Diagnostics;
using App.Context;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        ProdutoBannerViewModel viewModel = new ProdutoBannerViewModel
        {
            ListaProdutos = _context.Produto.ToList(),
            ListaBanners = _context.Banners.ToList()
        };
        return View(viewModel);
        //return View(_context.Produto.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
