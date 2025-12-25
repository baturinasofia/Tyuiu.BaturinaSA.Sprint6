using Tyuiu.BaturinaSA.Sprint6.Task6.V27.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string s = @"C:\Users\Софья\source\repos\WinFormsAppChart\Tyuiu.BaturinaSA.Sprint6.Task6.V27\InPutFileTask6V27.txt.txt";
            Assert.AreEqual(ds.CollectTextFromFile(s), "Hello Holl");
        }
    }
}
