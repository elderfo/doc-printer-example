namespace CPrint.Logic.Documents
{
    internal class PrintableDocument : IDocument
    {
        public string Path { get; set; }

        public DocumentType DocumentType { get; set; }

        public static PrintableDocument Create(IDocument document)
        {
            return new PrintableDocument
            {
                Path = document.Path,
                DocumentType = document.DocumentType
            };
        }

        internal void Print(IPrinter printer)
        {
            if (printer == null)
            {
                throw new NoPrinterException();
            }

            if (!printer.CanUse(DocumentType) )
            {
                throw new CannotPrintException(DocumentType);
            }

            printer.Print(this);
        }
    }
}