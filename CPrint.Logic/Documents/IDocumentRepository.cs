using System.Collections.Generic;

namespace CPrint.Logic.Documents
{
    public interface IDocumentRepository
    {
        IEnumerable<IDocument> GetAllDocuments();
    }
}
