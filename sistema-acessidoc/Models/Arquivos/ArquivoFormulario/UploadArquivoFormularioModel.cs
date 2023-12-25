using sistema_acessidoc.Models.Arquivos.ArquivoFormulario.ArquivoFormularioEnum;
using System.ComponentModel.DataAnnotations;

namespace sistema_acessidoc.Models.Arquivos.ArquivoFormulario
{
    public class UploadArquivoFormularioModel
    {
        public string NomeDoArquivo { get; }

        [Required(ErrorMessage = "Escolha um tamanho de fonte: 18 ou 24!")]
        public OpcaoDeTamanhoFonteArquivo? TamanhoFonteArquivo { get; set; }

        [Required(ErrorMessage = "Um arquivo em formato PDF ou DOC deve ser anexado!")]
        public IFormFile ArquivoAnexadoFormulario {  get; set; }
    }
}