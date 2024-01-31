namespace RefaktoriranjeZadatak
{
    public class someClass
    {
        double[] mostDistant(List<double[]> arrays, double[] target)
        {
            double max = 0, dist;
            int idxMax = 0; //index of the farthest in arrays from target
            for (int i = 0; i < arrays.Count; i++)
            {
                dist = 0; // Euclidean distance between target and i-th vector in arrays 
                for (int j = 0; j < arrays[i].Length; j++)
                    dist += (target[j] - arrays[i][j]) * (target[j] - arrays[i][j]);
                dist = Math.Sqrt(dist);

                if (i == 0 || dist > max)
                {
                    max = dist;
                    idxMax = i;
                }
            }
            return arrays[idxMax]; // farthest from target
        }
    }
}