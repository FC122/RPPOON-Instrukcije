/*Napisite unit test koji provjerava ispravan rad metode dane sljedecim izlistanjem koda*/

namespace SestiZadatak
{
    class Statistics
    {
        public static double FindLargestRange(List<List<Double>> measurements)
        {
            double largestRange = 0;
            for (int i = 0; i < measurements.Count(); i++)
            {
                double range = measurements[i].Max() - measurements[i].Min();
                if (i == 0 || range > largestRange)
                {
                    largestRange = range;
                }
            }
            return largestRange;
        }
    }
}