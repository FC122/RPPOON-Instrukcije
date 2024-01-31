namespace RefaktoriranjeRjesenje
{
    public class someClass
    {
        double[] FindMostDistant(List<double[]> arrays, double[] target)
        {
            double maxDistance = 0;
            int farthestIndex = 0;

            for (int i = 0; i < arrays.Count; i++)
            {
                double distance = CalculateEuclideanDistance(arrays[i], target);

                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    farthestIndex = i;
                }
            }

            return arrays[farthestIndex];
        }

        double CalculateEuclideanDistance(double[] array1, double[] array2)
        {
            double sumOfSquares = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                double difference = array1[i] - array2[i];
                sumOfSquares += difference * difference;
            }

            return Math.Sqrt(sumOfSquares);
        }
    }
}