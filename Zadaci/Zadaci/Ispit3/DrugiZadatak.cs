namespace DrugiZadatakIspit3
{
    /*Refaktoriraj kod dan u sljedecem izlistanju*/
    class DistinctClass
    {
        //static method that returns an integer and takes an array of integers as input
        public static int Distinct(List<int> intList)
        {
            int res = 0;//final result
            for (int i = 0; i < intList.Count; i++)
            {
                int flag = 0; // flag for counting
                for (int j = 0; j < intList.Count; j++)
                {
                    if (intList[i] == intList[j])
                    {
                        flag++; // occurrence counting
                    }
                }
                if (flag == 1)
                {
                    res++; // distinct count
                }
            }
            return res; // the result of counting
        }

    }
}