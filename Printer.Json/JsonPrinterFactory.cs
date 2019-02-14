using PrinterLogic;
using PrinterLogic.Documents;

namespace Printer.Json
{
    public class JsonPrinterFactory : IPrinterFactory
    {
        private readonly string _outputPath;

        public JsonPrinterFactory(string outputPath)
        {
            _outputPath = outputPath;
        }
        public IPrinter CreatePrinter()
        {
            return new JsonPrinter(_outputPath);
        }
    }
}
