using NUnit.Framework;
using CPrint.Logic.Documents;

namespace CPrint.Logic.Tests.Documents
{
    class PrintableDocumentTests
    {
        [Test]
        public void Create_ReturnsMatchingProperties()
        {
            var source = TestUtils.CreateRandom<StubDocument>();

            var actual = PrintableDocument.Create(source);

            Assert.That(actual.DocumentType, Is.EqualTo(source.DocumentType));
            Assert.That(actual.Path, Is.EqualTo(source.Path));
        }

        [Test]
        public void Print_WithNonSuitablePrinter_ThrowsCannotPrintException()
        {
            var document = CreateRandomDocument();
            var printer = new FakePrinter(false);

            Assert.Throws<CannotPrintException>(() =>
            {
                document.Print(printer);
            });
        }

        [Test]
        public void Print_WithSuitablePrinter_PrintsSpecifiedDocument()
        {
            var document = CreateRandomDocument();
            var printer = new FakePrinter(true);

            document.Print(printer);

            Assert.That(printer.PrintedDocuments, Has.Member(document));
        }

        [Test]
        public void Print_WithNoPrinter_ThrowsNoPrinterException()
        {
            var document = CreateRandomDocument();

            Assert.Throws<NoPrinterException>(() =>
            {
                document.Print(null);
            });
        }

        private PrintableDocument CreateRandomDocument()
        {
            return PrintableDocument.Create(TestUtils.CreateRandom<StubDocument>());
        }
    }
}
