using PrinterLogic.Documents;
using PrinterLogic.Printing;

namespace PrinterLogic
{
    public class ManagerFactory
    {
        private readonly IPrinterFactory _printerFactory;
        private readonly IRepositoryFactory _repositoryFactory;

        public ManagerFactory(IPrinterFactory printerFactory, IRepositoryFactory repositoryFactory)
        {
            _printerFactory = printerFactory;
            _repositoryFactory = repositoryFactory;
        }

        public IPrintManager CreatePrintManager()
        {
            var printer = _printerFactory.CreatePrinter();
            return new PrintManager(printer);
        }

        public IDocumentManager CreateDocumentManager()
        {
            var repository = _repositoryFactory.CreateDocumentRepository();
            return new DocumentManager(repository);
        }
    }
}
