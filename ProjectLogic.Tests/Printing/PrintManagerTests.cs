using NUnit.Framework;
using PrinterLogic.Documents;
using PrinterLogic.Printing;
using PrinterLogic.Tests.Documents;

namespace PrinterLogic.Tests.Printing
{
    class PrintManagerTests
    {
        [Test]
        public void PrintDocuments_WithValidPrinter_PrintsAllDocuments()
        {
            var documents = new[]
            {
                TestUtils.CreateRandom<StubDocument>(),
                TestUtils.CreateRandom<StubDocument>(),
            };

            var printer = new FakePrinter(true);

            var printManager = CreateSystemUnderTest(printer);

            printManager.PrintDocuments(documents);

            Assert.That(printer.PrintedDocuments, Is.EquivalentTo(documents));
        }

        private PrintManager CreateSystemUnderTest(IPrinter printer)
        {
            return new PrintManager(printer);
        }
    }
}
