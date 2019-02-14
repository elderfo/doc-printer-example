using CPrint.Logic.Documents;

namespace CPrint.Logic
{
    public interface IRepositoryFactory
    {
        IDocumentRepository CreateDocumentRepository();
    }
}