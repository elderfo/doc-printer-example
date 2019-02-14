using System;
using System.Collections.Generic;
using PrinterLogic.Documents;

namespace PrinterLogic.Printing
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
