using cabInVoice;

namespace MsCabInvoice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]



        public void TestMethod1()
        {
            
            double distance = 2.0;
            int time = 5;
            double expected = 25;
            double actual =cabInVoice.Program.totalFair(distance, time);
            Assert.AreEqual(expected, actual);
        }
    }
}