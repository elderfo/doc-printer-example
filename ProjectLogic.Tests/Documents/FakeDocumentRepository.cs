using PrinterLogic.Documents;
using System.Collections.Generic;

namespace PrinterLogic.Tests.Documents
{
    public class FakeDocumentRepository : IDocumentRepository
    {
        private readonly IEnumerable<IDocument> _documents;

        public FakeDocumentRepository(IEnumerable<IDocument> documents)
        {
            _documents = documents;
        }

        public IEnumerable<IDocument> GetAllDocuments()
        {
            return _documents;
        }
    }
}
