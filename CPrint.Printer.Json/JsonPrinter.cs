using Newtonsoft.Json;
using CPrint.Logic.Documents;
using System.IO;

namespace CPrint.Printer.Json
{
    public class JsonPrinter : IPrinter
    {
        private readonly string _storagePath;

        public JsonPrinter(string storagePath)
        {
            _storagePath = storagePath;
        }
        public bool CanUse(DocumentType documentType)
        {
            return true;
        }

        public void Print(IDocument document)
        {
            string json = JsonConvert.SerializeObject(document);
            string filename = document.Path.Replace('\\', '~') + ".json";

            string outputPath = Path.Combine(_storagePath, filename);
            File.WriteAllText(outputPath, json);
        }
    }
}
