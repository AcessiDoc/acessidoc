using Aspose.Words;

namespace sistema_acessidoc.Models.Arquivos.Documento
{
    public class DocumentoBase
    {
        public static Document Documento { get; set; }
        public static DocumentBuilder DocumentoEmConstrucao { get; set; }

        public DocumentoBase(Document documento, DocumentBuilder documentoEmConstrucao)
        {
            Documento = documento;
            DocumentoEmConstrucao = documentoEmConstrucao;
        }
    }
}