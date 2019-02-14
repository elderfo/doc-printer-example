using PrinterLogic.Documents;

namespace PrinterLogic
{
    public interface IRepositoryFactory
    {
        IDocumentRepository CreateDocumentRepository();
    }
}