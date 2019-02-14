using CPrint.Logic;
using System.Linq;
using System.Reflection;
using CPrint.Data.FileSystem;
using CPrint.Printer.Json;

namespace CPrint.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositoryFactory = new FileSystemRepositoryFactory(args.First());

            var printerOutputDir = args.LastOrDefault() ?? Assembly.GetExecutingAssembly().Location;
            var printerFactory = new JsonPrinterFactory(printerOutputDir);

            var managerFactory = new ManagerFactory(printerFactory, repositoryFactory);
        }
    }
}
