using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaAcessiDoc.Models;
using sistema_acessidoc.Context;
using System.Linq;

public class LoginController : Controller
{
    private readonly AcessiDocContext _dbContext;

    public LoginController(AcessiDocContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string senha)
    {
        // Verifica se as credenciais estão corretas
        var usuario = _dbContext.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

        if (usuario != null)
        {
            // Login válido, redireciona para a página inicial
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Login inválido, exiba uma mensagem de erro
            ViewBag.MensagemErro = "Login inválido, tente novamente.";
            return View();
        }
    }
}
