using NUnit.Framework;
using CPrint.Logic.Documents;
using System.Collections.Generic;

namespace CPrint.Logic.Tests.Documents
{
    class DocumentManagerTests
    {

        [Test]
        public void GetDocuments_WhenNoDocumentsFound_ReturnsEmptyEnumerable()
        {
            DocumentManager documentManager = CreateSystemUnderTest();

            IEnumerable<IDocument> actual = documentManager.GetDocuments();

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void GetDocuments_WithDocuments_ReturnsExpectedDocuments()
        {
            var doc1 = TestUtils.CreateRandom<StubDocument>();
            var doc2 = TestUtils.CreateRandom<StubDocument>();

            var documentManager = CreateSystemUnderTest(doc1, doc2);

            var actual = documentManager.GetDocuments();

            Assert.That(actual, Has.Member(doc1));
            Assert.That(actual, Has.Member(doc2));
        }

        private DocumentManager CreateSystemUnderTest(params IDocument[] documents)
        {
            var repository = new FakeDocumentRepository(documents);

            return new DocumentManager(repository);
        }
    }
}
