using Microsoft.AspNetCore.Mvc;
using sistema_acessidoc.Models;
using sistema_acessidoc.Models.Arquivos.ArquivoFormulario;
using sistema_acessidoc.Models.Error;
using System.Diagnostics;

namespace sistema_acessidoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MinhasEdicoes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(UploadArquivoFormularioModel arquivo)
        {
            try
            {
                if (arquivo.ArquivoAnexadoFormulario != null && arquivo.ArquivoAnexadoFormulario.Length > 0)
                {
                    var nomeDoArquivoAnexado = Path.GetFileName(arquivo.ArquivoAnexadoFormulario.FileName);
                    var tamanhoDaFonteEscolhidoPeloUsuario = arquivo.TamanhoFonteArquivo;
                    var arquivoDeTexto = arquivo.ArquivoAnexadoFormulario;

                    using (var novoArquivo = new FileStream(nomeDoArquivoAnexado, FileMode.CreateNew))

                    ViewBag.NomeArquivo = nomeDoArquivoAnexado;
                    ViewBag.TamanhoFonteEscolhido = tamanhoDaFonteEscolhidoPeloUsuario;
                    ViewBag.ArquivoParaConversao = arquivoDeTexto;

                    return View();
                }
                else
                {
                    ViewBag.UploadMensagemArquivoNaoAnexado = "Selecione um arquivo para conversão.";
                }
            }
            catch (Exception exception)
            {
                ModelState.AddModelError(string.Empty, $"Ocorreu um erro, tente novamente!");
            }
            return View(arquivo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}