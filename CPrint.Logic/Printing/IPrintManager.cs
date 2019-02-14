using CPrint.Logic.Documents;
using System.Collections.Generic;

namespace CPrint.Logic.Printing
{
    public interface IPrintManager
    {
        void PrintDocuments(IEnumerable<IDocument> documents);
    }
}