using System.Collections.Generic;

namespace PrinterLogic.Documents
{
    public interface IDocumentManager
    {
        IEnumerable<IDocument> GetDocuments();
    }
}