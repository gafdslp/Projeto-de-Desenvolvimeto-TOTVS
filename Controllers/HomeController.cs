using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_de_Desenvolvimeto_TOTVS;
using Projeto_de_Desenvolvimeto_TOTVS.Data;
using Projeto_de_Desenvolvimeto_TOTVS.Models;

namespace Projeto_de_Desenvolvimeto_TOTVS.Controllers;

    public class HomeController : Controller
{

    readonly private ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }


    public IActionResult Index()
    {

        IEnumerable<CadastrosModel> cadastros = _db.Cadastros;
        return View(cadastros);
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CadastrosModel cadastros)
    {

        if (ModelState.IsValid)
        {
            _db.Cadastros.Add(cadastros);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        return View();
    }

    public IActionResult CreateDynamic()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
