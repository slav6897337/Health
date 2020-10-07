using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestHealth
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Output_Test1()
        {
            string name = "Leonid";
            double bodyTemp = 34;
            string expected = "Leonid, your body temperature 34. Please Visit a doctor";

            string actual = Health.Program.Output(name, bodyTemp);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Output_Test2()
        {
            string name = "Leonid";
            double bodyTemp = 38;
            string expected = "Leonid, your body temperature 38. Please Visit a doctor";

            string actual = Health.Program.Output(name, bodyTemp);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Output_Test3()
        {
            string name = "Leonid";
            double bodyTemp = 36;
            string expected = "Leonid, your body temperature 36. You may pass";

            string actual = Health.Program.Output(name, bodyTemp);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Output_Test4()
        {
            string name = "Leonid";
            double bodyTemp = 36.9;
            string expected = "Leonid, your body temperature 36.9. Get some rest";

            string actual = Health.Program.Output(name, bodyTemp);

            Assert.AreEqual(expected, actual);
        }
    }
}
