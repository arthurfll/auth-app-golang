using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Core.Data;
using System.Security.Claims;

namespace Core.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _db = db;
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (User.Identity.IsAuthenticated) return Redirect("/Home/List");
        else return View();
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet, Authorize]
    public IActionResult List()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var data = _db.Revisoes.Where(x => x.UserId == userId).ToList();
        if (data == null) data = new List<Revisao>();
        return View(data);
    }

    [HttpPost]
    public IActionResult Create(Revisao obj)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        obj.UserId = userId;
        _db.Revisoes.Add(obj);
        _db.SaveChanges();
        return Redirect("/Home/List");
    }

    [HttpPost]
[Authorize]
public IActionResult Update(Revisao obj)
{
    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

    var revisaoDb = _db.Revisoes
        .FirstOrDefault(x => x.Id == obj.Id && x.UserId == userId);

    if (revisaoDb == null)
        return Unauthorized();

    revisaoDb.Conceito = obj.Conceito;
    revisaoDb.Link = obj.Link;
    revisaoDb.MotivoDoErro = obj.MotivoDoErro;

    revisaoDb.DataDaCorrecao = obj.DataDaCorrecao;

    revisaoDb.Revisao1Check = obj.Revisao1Check;
    revisaoDb.Revisao2Check = obj.Revisao2Check;
    revisaoDb.Revisao3Check = obj.Revisao3Check;
    revisaoDb.Revisao4Check = obj.Revisao4Check;
    revisaoDb.Revisao5Check = obj.Revisao5Check;

    _db.SaveChanges();

    return Redirect("/Home/List");
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


