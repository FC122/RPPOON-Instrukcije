namespace DrugiZadatakRjesenjeIspit3
{
    /*Refaktoriraj kod dan u sljedecem izlistanju*/
    class DistinctClass
    {
        public static int CountDistinctNumbers(List<int> array)
        {
            int counter = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (CountOccurrences(array, array[i]) == 1)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int CountOccurrences(List<int> array, int number)
        {
            int occurrence = 0;
            for (int j = 0; j < array.Count; j++)
            {
                if (number == array[j])
                {
                    occurrence++;
                }
            }
            return occurrence;
        }
    }
}