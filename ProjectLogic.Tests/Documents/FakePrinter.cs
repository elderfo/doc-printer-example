using PrinterLogic.Documents;
using System.Collections.Generic;

namespace PrinterLogic.Tests.Documents
{
    internal class FakePrinter : IPrinter
    {
        private readonly bool canUse;
        private readonly IList<IDocument> _printedDocuments = new List<IDocument>();

        public IEnumerable<IDocument> PrintedDocuments => _printedDocuments;
        public FakePrinter(bool canUse)
        {
            this.canUse = canUse;
        }

        public void Print(IDocument document)
        {
            _printedDocuments.Add(document);
        }

        public bool CanUse(DocumentType documentType)
        {
            return canUse;
        }
    }
}