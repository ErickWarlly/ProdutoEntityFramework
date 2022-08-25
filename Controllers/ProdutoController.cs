using Demostracao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demostracao.Controllers;

//Controller reponsavel pelas Ações de Listar o banco de dados | Cadastrar um novo elemento | Detlhar um elemento
public class ProdutoController : Controller
{
    private readonly Connection _connection;

    public ProdutoController(Connection connection)
    {
        _connection = connection;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _connection.Produto.ToListAsync());
    }
    public ActionResult Editar()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Produto prod)
    {
        _connection.Produto.Add(prod);
        _connection.SaveChanges();
        return View("Index");
    }

    [HttpGet]
    public IActionResult Detalhe(int? index)
    {
        var prod = _connection.Produto.Where(x => x.id == index).FirstOrDefault();

        return View(prod);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}
