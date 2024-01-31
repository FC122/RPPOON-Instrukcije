/*Refaktoriraj kod dan u sljedecem izlistanju*/
namespace DrugiZadatakRjesenje
{

    class Avg
    {
        List<double> CalculateAverages(List<double[]> arrays)
        {
            List<double> averages = new List<double>(); // resulting list of doubles;
            foreach (double[] array in arrays)
            {
                averages.Add(CalculateAverage(array));
            }
            return averages;
        }

        double CalculateAverage(double[] array)
        {
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            return average / array.Length;
        }
    }

}