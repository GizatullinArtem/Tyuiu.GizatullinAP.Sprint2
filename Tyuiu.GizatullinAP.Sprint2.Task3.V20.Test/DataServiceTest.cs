using Tyuiu.GizatullinAP.Sprint2.Task3.V20.Lib;
namespace Tyuiu.GizatullinAP.Sprint2.Task3.V20.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 4.5;
            Assert.AreEqual(wait, res);




        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);


        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 1.02;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = ds.Calculate(x);
            double wait = -274.96;
            Assert.AreEqual(wait, res);
        }
    }
}
