/*Napisite unit test koji provjerava ispravan rad metode dane 
sljedecim izlistanjem koda*/

namespace SestiZadatakRjesenje
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

    // [TestFixture]
    // class StatisticsTests
    // {
    //     [Test]
    //     public void FindLargestRange_Returns_CorrectValue()
    //     {
    //         // Arrange
    //         List<List<double>> measurements = new List<List<double>> {
    //             new List<double> { 1, 3, 5, 7, 9 }};
    //         // Act
    //         double result = Statistics.FindLargestRange(measurements);
    //         // Assert
    //         Assert.AreEqual(8, result);
    //     }
    // }
}