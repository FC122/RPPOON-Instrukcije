/*Napisite unit test koji provjerava ispravan rad metode dane sljedecim izlistanjem koda koda*/

namespace SestiZadatakRjesenjeTest3
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

    // [TestFixture]
    // public class EntryValidatorTests
    // {
    //     [Test]
    //     public void ObservedEnoughSquares_ReturnsTrue_WhenEnoughObservations()
    //     {
    //         // Arrange
    //         EntryValidator validator = new EntryValidator(3);
    //         List<int> entries = new List<int> { 1, 2, 3, 4, 5 };
    //         List<int> observations = new List<int> { 1, 2, 3 };

    //         // Act
    //         bool result = validator.ObservedEnoughSquares(entries, observations);

    //         // Assert
    //         Assert.IsTrue(result);
    //     }
    // }
}