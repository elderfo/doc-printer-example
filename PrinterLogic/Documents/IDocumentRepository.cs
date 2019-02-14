using System.Collections.Generic;

namespace PrinterLogic.Documents
{
    public interface IDocumentRepository
    {
        IEnumerable<IDocument> GetAllDocuments();
    }
}
