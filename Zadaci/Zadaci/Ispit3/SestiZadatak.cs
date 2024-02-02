/*Napisite unit test koji provjerava ispravan rad metode dane sljedecim izlistanjem koda koda*/

namespace SestiZadatakTest3
{
    class EntryValidator
    {
        private int threshold;

        public EntryValidator(int threshold)
        {
            this.threshold = threshold;
        }

        public bool ObservedEnoughSquares(List<int> entries, List<int> observations)
        {
            if (entries == null || observations == null)
            {
                return false;
            }

            int squares = 0;
            foreach (int entry in entries)
            {
                foreach (int observation in observations)
                {
                    if (entry == observation)
                    {
                        squares++;
                    }
                }
            }

            return squares >= threshold;
        }
    }
}