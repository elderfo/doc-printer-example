using NUnit.Framework;
using CPrint.Logic.Documents;
using CPrint.Logic.Printing;
using CPrint.Logic.Tests.Documents;

namespace CPrint.Logic.Tests.Printing
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
