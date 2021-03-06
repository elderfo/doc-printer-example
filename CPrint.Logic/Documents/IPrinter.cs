﻿namespace CPrint.Logic.Documents
{
    public interface IPrinter
    {
        void Print(IDocument document);

        bool CanUse(DocumentType documentType);
    }
}