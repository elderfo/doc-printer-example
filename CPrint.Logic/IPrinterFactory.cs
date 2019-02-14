using CPrint.Logic.Documents;

namespace CPrint.Logic
{
    public interface IPrinterFactory
    {
        IPrinter CreatePrinter();
    }
}