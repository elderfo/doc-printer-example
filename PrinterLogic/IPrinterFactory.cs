using PrinterLogic.Documents;

namespace PrinterLogic
{
    public interface IPrinterFactory
    {
        IPrinter CreatePrinter();
    }
}