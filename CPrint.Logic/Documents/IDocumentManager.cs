using System.Collections.Generic;

namespace CPrint.Logic.Documents
{
    public interface IDocumentManager
    {
        IEnumerable<IDocument> GetDocuments();
    }
}