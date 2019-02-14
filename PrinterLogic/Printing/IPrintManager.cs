using PrinterLogic.Documents;
using System.Collections.Generic;

namespace PrinterLogic.Printing
{
    public interface IPrintManager
    {
        void PrintDocuments(IEnumerable<IDocument> documents);
    }
}