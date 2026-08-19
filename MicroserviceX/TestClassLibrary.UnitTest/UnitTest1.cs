namespace TestClassLibrary.UnitTest
{
    [TestClass]
    public sealed class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 cl = new Class1 { Id = 1, Name = "Test" };

            Assert.AreEqual(1, cl.Id);
            Assert.AreEqual("Test", cl.Name);
        }
    }
}
