namespace MicroY.UnitTest
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


        [TestMethod]
        public void TestMethod2()
        {
            Class1 c = new Class1 { Id = 1, Name = "C1" };

            Assert.AreEqual(1, c.Id);
        }
    }
}
