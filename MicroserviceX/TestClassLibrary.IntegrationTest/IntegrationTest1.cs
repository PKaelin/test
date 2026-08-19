using TestClassLibrary.Infra;

namespace TestClassLibrary.IntegrationTest
{
    [TestClass]
    public sealed class IntegrationTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClassContext context = new TestClassContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
