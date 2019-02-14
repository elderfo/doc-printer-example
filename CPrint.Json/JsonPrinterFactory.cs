using CPrint.Logic;
using CPrint.Logic.Documents;

namespace CPrint.Printer.Json
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
