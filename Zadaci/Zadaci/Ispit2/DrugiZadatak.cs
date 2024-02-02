/*Refaktoriraj kod dan u sljedecem izlistanju*/
namespace DrugiZadatak
{

    class Avg
    {
        List<double> Averages(List<double[]> arraysList)
        {
            List<double> avgs = new List<double>(); // resulting list of doubles;
            foreach (double[] a in arraysList)
            {
                double s = 0; // reset necessary
                for (int i = 0; i < a.Length; i++)
                    s += a[i];
                avgs.Add(s / a.Length);
            }
            return avgs;
        }

        double CalculateAvereage(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum / array.Length;
        }
    }

}