using System.Collections.Generic;
using System.IO;
using System.Linq;
using CPrint.Logic.Documents;

namespace CPrint.Data.FileSystem
{
    class FileSystemDocumentRepository : IDocumentRepository
    {
        private readonly string _searchPath;

        public FileSystemDocumentRepository(string searchPath)
        {
            _searchPath = searchPath;
        }

        public IEnumerable<IDocument> GetAllDocuments()
        {
            var wordDocs = Directory.GetFiles(_searchPath, "*.docx", SearchOption.AllDirectories)
                .Select(s => new FileDocument
                {
                    Path = s,
                    DocumentType = DocumentType.Word
                });
            var excelDocs = Directory.GetFiles(_searchPath, "*.xlsx", SearchOption.AllDirectories)
                .Select(s => new FileDocument
                {
                    Path = s,
                    DocumentType = DocumentType.Excel
                });
            var pdfDocs = Directory.GetFiles(_searchPath, "*.pdf", SearchOption.AllDirectories)
                .Select(s => new FileDocument
                {
                    Path = s,
                    DocumentType = DocumentType.Pdf
                });

            return wordDocs.Concat(excelDocs).Concat(pdfDocs);
        }
    }

    class FileDocument : IDocument
    {
        public DocumentType DocumentType { get; set; }
        public string Path { get; set; }
    }

}
