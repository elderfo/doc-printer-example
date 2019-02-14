using PrinterLogic;
using PrinterLogic.Documents;

namespace Printer.Data.FileSystem
{
    public class FileSystemRepositoryFactory : IRepositoryFactory
    {
        private readonly string _searchPath;

        public FileSystemRepositoryFactory(string searchPath)
        {
            _searchPath = searchPath;
        }

        public IDocumentRepository CreateDocumentRepository()
        {
            return new FileSystemDocumentRepository(_searchPath);
        }
    }

}
