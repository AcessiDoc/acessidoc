using Aspose.Words;
using sistema_acessidoc.Models.Arquivos.Documento;

namespace sistema_acessidoc.Models.Arquivos.EntidadesDeFormatacao
{
    public static class ContagemPaginaArquivo
    {
        public static void ConfigurarContagemDePaginasNoArquivo()
        {
            // Evita a exibição de uma marca d'água no arquivo,
            // que geralmente ocorre quando a biblioteca é usada sem uma licença válida.

            var licencaAsposeWords = new Aspose.Words.License();
            licencaAsposeWords.SetLicense("Aspose.Word.lic");

            // Vai para a seção primária do rodapé do arquivo
            DocumentoBase.DocumentoEmConstrucao.MoveToHeaderFooter(Aspose.Words.HeaderFooterType.FooterPrimary);

            // Adiciona o número da página campo junto com a condição usando IF
            Aspose.Words.Fields.Field campo = DocumentoBase.DocumentoEmConstrucao.InsertField("IF ", null);
            DocumentoBase.DocumentoEmConstrucao.MoveTo(campo.Start.NextSibling.NextSibling);

            // Insere o campo no rodapé
            DocumentoBase.DocumentoEmConstrucao.InsertField(Aspose.Words.Fields.FieldType.FieldPage, false);

            // Adiciona a expressão IF a ser verificada antes de inserir o número da página
            DocumentoBase.DocumentoEmConstrucao.Write(" > 4 \"");

            // No segmento TRUE da condição IF adiciona outro campo
            DocumentoBase.DocumentoEmConstrucao.InsertField(Aspose.Words.Fields.FieldType.FieldPage, false);

            // Na parte FALSE da condição IF, insere uma string em branco
            DocumentoBase.DocumentoEmConstrucao.Write("\" \"\"");

            // Vai para o início do documento para adicionar páginas em branco
            DocumentoBase.DocumentoEmConstrucao.MoveToDocumentStart();

            // Insire um número definido de páginas em branco que poderá ser ajustdo conforme necessidades
            for (int page = 0; page < 15; page++)
            {
                DocumentoBase.DocumentoEmConstrucao.InsertBreak(Aspose.Words.BreakType.PageBreak);
            }
        }
    }
}