namespace MicroY.IntegrationTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1 { Id = 1, Name = "C1" };

            Assert.IsNotNull(c.Name);
        }
    }
}
