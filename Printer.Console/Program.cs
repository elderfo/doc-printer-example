using PrinterLogic;
using System.Linq;
using System.Reflection;
using Printer.Data.FileSystem;

namespace Printer.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositoryFactory = new FileSystemRepositoryFactory(args.First());

            var printerOutputDir = args.LastOrDefault() ?? Assembly.GetExecutingAssembly().Location;
            var printerFactory = new Json.JsonPrinterFactory(printerOutputDir);

            var managerFactory = new ManagerFactory(printerFactory, repositoryFactory);
        }
    }
}
