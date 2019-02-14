namespace PrinterLogic.Documents
{
    internal interface IPrinter
    {
        void Print(IDocument document);

        bool CanUse(DocumentType documentType);
    }
}