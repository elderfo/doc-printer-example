using System;
using System.Collections.Generic;
using CPrint.Logic.Documents;

namespace CPrint.Logic.Printing
{
    internal class PrintManager : IPrintManager
    {
        private readonly IPrinter printer;

        public PrintManager(IPrinter printer)
        {
            this.printer = printer;
        }

        public void PrintDocuments(IEnumerable<IDocument> documents)
        {
            foreach (var document in documents)
            {
                var printableDocument = PrintableDocument.Create(document);
                printableDocument.Print(printer);
            }
        }
    }
}
