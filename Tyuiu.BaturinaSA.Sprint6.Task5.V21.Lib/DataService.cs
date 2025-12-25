using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BaturinaSA.Sprint6.Task5.V21.Lib
{
    public class DataService : ISprint6Task5V21
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            var numsList = new System.Collections.Generic.List<double>();

            foreach (var line in lines)
            {
                string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {
                    string normalizedPart = part.Replace(',', '.');
                    if (double.TryParse(normalizedPart, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        numsList.Add(number);
                    }
                }
            }
            double[] NumsArray = numsList.ToArray();
            NumsArray = NumsArray.Where(val => val % 3 == 0).ToArray();
            return NumsArray;
        }
    }
}
        
    

