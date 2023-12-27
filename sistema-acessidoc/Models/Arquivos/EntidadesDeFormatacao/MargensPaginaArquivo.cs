using Aspose.Words;
using sistema_acessidoc.Models.Arquivos.Documento;

namespace sistema_acessidoc.Models.Arquivos.EntidadesDeFormatacao
{
    public static class MargensPaginaArquivo
    {
        public static void ConfigurarTamanhoFolhaEMargensDoArquivo()
        {
            DocumentoBase.DocumentoEmConstrucao.PageSetup.PaperSize = PaperSize.A4;
            DocumentoBase.DocumentoEmConstrucao.PageSetup.Orientation = Orientation.Portrait;
            DocumentoBase.DocumentoEmConstrucao.PageSetup.TopMargin = ConvertUtil.InchToPoint(3.0);
            DocumentoBase.DocumentoEmConstrucao.PageSetup.BottomMargin = ConvertUtil.InchToPoint(2.0);
            DocumentoBase.DocumentoEmConstrucao.PageSetup.LeftMargin = ConvertUtil.InchToPoint(2.0);
            DocumentoBase.DocumentoEmConstrucao.PageSetup.RightMargin = ConvertUtil.InchToPoint(3.0);
        }
    }
}
