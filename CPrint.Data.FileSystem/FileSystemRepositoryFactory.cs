using CPrint.Logic;
using CPrint.Logic.Documents;

namespace CPrint.Data.FileSystem
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
