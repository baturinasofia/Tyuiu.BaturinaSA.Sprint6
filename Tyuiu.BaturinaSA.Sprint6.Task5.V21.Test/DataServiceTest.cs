using Tyuiu.BaturinaSA.Sprint6.Task5.V21.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Софья\source\repos\WinFormsAppChart\Tyuiu.BaturinaSA.Sprint6.Task5.V21\InPutDataFileTask5V21.txt";
            DataService ds = new DataService();

            double[] wait;
            wait = new double[2];
            wait[0] = 12;
            wait[1] = -9;

            double[] valueArray;
            valueArray = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}
