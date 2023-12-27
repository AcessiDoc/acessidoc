using Aspose.Words;
using sistema_acessidoc.Models.Arquivos.Documento;
using sistema_acessidoc.Models.Exceptions;

namespace sistema_acessidoc.Models.Arquivos.EntidadesDeFormatacao
{
    public static class FontePaginaArquivo
    {
        public static int FontePadrao { get; set; } = 18;
        public static int FonteAmpliada { get; set; } = 24;
        public static string NomeFontePadraoDocumento { get; set; } = "Arial";

        public static void ConfigurarTamanhoDaFonteDoArquivo(int tamanhoFonte)
        {
            // Faz a verificação do tamanho da fonte escolhida pelo usuário

            if (tamanhoFonte == 18)
            {
                Font fonte = DocumentoBase.DocumentoEmConstrucao.Font;
                fonte.Size = FontePadrao;
            }

            if (tamanhoFonte == 24)
            {
                Font fonte = DocumentoBase.DocumentoEmConstrucao.Font;
                fonte.Size = FonteAmpliada;
            }

            else
            {
                throw new TamanhoDeFonteInvalidoException("Tamanho da fonte indicada não está disponível.");
            }
        }

        public static void ConigurarFonteDoArquivo()
        {
            // Fonte padrão do texto
            DocumentoBase.DocumentoEmConstrucao.Font.Name = NomeFontePadraoDocumento;
        }
    }
}
