namespace DrugiZadatak
{
    // scales the vector to unit length
    public class LengthManager
    {
        public LengthManager()
        {
            double[] array = { 1, 2, 3 };
            unitLengthScaler(array);
        }
        //Refaktorirajte kod dan u sljedecem izlistanju
        void unitLengthScaler(double[] array)
        {
            double L2 = 0;
            // Euclidean distance of the vector to the origin
            // also called the L2 norm (or Euclidean norm) of the vector
            for (int i = 0; i < array.Length; i++)
                L2 += array[i] * array[i];
            L2 = Math.Sqrt(L2);
            // just divide each vector component by its L2 norm
            for (int i = 0; i < array.Length; i++)
                array[i] /= L2;
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
        }
    }

}