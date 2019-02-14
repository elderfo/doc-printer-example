using System.Collections.Generic;

namespace PrinterLogic.Documents
{
    internal class DocumentManager : IDocumentManager
    {
        private readonly IDocumentRepository documentRepository;

        public DocumentManager(IDocumentRepository documentRepository)
        {
            this.documentRepository = documentRepository;
        }

        public IEnumerable<IDocument> GetDocuments()
        {
            return documentRepository.GetAllDocuments();
        }
    }
}
