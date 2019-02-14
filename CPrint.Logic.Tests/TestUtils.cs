using AutoFixture;

namespace CPrint.Logic.Tests
{
    static class TestUtils
    {
        private static readonly Fixture _fixture = new Fixture();

        public static T CreateRandom<T>()
        {
            return _fixture.Create<T>();
        }
    }
}
