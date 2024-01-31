/*Napisite unit test koji provjerava ispravan rad metode dane sljedecim izlistanjem koda koda*/
namespace SestiZadatakRjesenje
{
    public class CompoundChecker
    {
        private List<string> harmfulCompounds;
        private int allowedHarmfulCompounds;

        public CompoundChecker(List<string> harmfulCompounds, int allowedHarmfulCompounds)
        {
            this.harmfulCompounds = harmfulCompounds;
            this.allowedHarmfulCompounds = allowedHarmfulCompounds;
        }

        public bool IsHarmful(string chemicalCompound)
        {
            int harmfulCompoundCount = 0;
            foreach (string harmfulCompound in harmfulCompounds)
            {
                if (chemicalCompound.Contains(harmfulCompound, StringComparison.OrdinalIgnoreCase))
                {
                    harmfulCompoundCount++;
                }
            }
            return harmfulCompoundCount > allowedHarmfulCompounds;
        }
    }

    // [TestFixture]
    // public class CompoundCheckerTests
    // {
    //     [Test]
    //     public void IsHarmful_ReturnsTrue_WhenChemicalCompoundIsHarmful()
    //     {
    //         // Arrange
    //         List<string> harmfulCompounds = new List<string> { "harmful1", "harmful2" };
    //         int allowedHarmfulCompounds = 1;
    //         CompoundChecker compoundChecker = new CompoundChecker(harmfulCompounds, allowedHarmfulCompounds);
    //         // Act
    //         bool result = compoundChecker.IsHarmful("This is a harmful1 compound.");
    //         // Assert
    //         Assert.IsTrue(result);
    //     }
    // }
}