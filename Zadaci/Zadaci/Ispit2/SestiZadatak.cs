/*Napisite unit test koji provjerava ispravan rad 
metode dane sljedecim izlistanjem koda koda*/
namespace SestiZadatak
{
    public class CompoundChecker
    {
        private List<string> harmfulCompounds;
        private int allowedHarmfulCompounds;

        public CompoundChecker(List<string> harmfulCompounds,
        int allowedHarmfulCompounds)
        {
            this.harmfulCompounds = harmfulCompounds;
            this.allowedHarmfulCompounds = allowedHarmfulCompounds;
        }

        public bool IsHarmful(string chemicalCompound)
        {
            int harmfulCompoundCount = 0;
            foreach (string harmfulCompound in harmfulCompounds)
            {
                if (chemicalCompound.Contains(harmfulCompound,
                    StringComparison.OrdinalIgnoreCase))
                {
                    harmfulCompoundCount++;
                }
            }
            return harmfulCompoundCount > allowedHarmfulCompounds;
        }
    }
}