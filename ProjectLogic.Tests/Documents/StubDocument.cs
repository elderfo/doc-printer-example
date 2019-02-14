using PrinterLogic.Documents;
using System;

namespace PrinterLogic.Tests.Documents
{
    public class StubDocument : IDocument
    {
        public DocumentType DocumentType { get; set; }
        public string Path { get; set; }

        public override bool Equals(object obj)
        {
            var document = obj as IDocument;
            return document != null &&
                   DocumentType == document.DocumentType &&
                   Path == document.Path;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DocumentType, Path);
        }

    }
}
