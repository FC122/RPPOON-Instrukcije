using BusinessLogic;

[TestFixture]
public class TrendEvaluatorTests
{
    [Test]
    public void ExtractTrend_Returns_Up_When_More_Ups()
    {
        // Arrange
        TrendEvaluator trendEvaluator = new TrendEvaluator(5);
        List<int> views = new List<int> { 1, 7, 5, 10, 12, 15 };

        // Act
        Trend trend = trendEvaluator.ExtractTrend(views);

        // Assert
        Assert.AreEqual(Trend.Up, trend);
    }

    [Test]
    public void ExtractTrend_Returns_Down_When_More_Downs()
    {
        // Arrange
        TrendEvaluator trendEvaluator = new TrendEvaluator(3);
        List<int> views = new List<int> { 15, 12, 10, 5, 3, 1 };

        // Act
        Trend trend = trendEvaluator.ExtractTrend(views);

        // Assert
        Assert.AreEqual(Trend.Down, trend);
    }

    [Test]
    public void ExtractTrend_Returns_Steady_When_Equal_Ups_and_Downs()
    {
        // Arrange
        TrendEvaluator trendEvaluator = new TrendEvaluator(5);
        List<int> views = new List<int> { 1, 6, 4, 8, 3, 7 };

        // Act
        Trend trend = trendEvaluator.ExtractTrend(views);

        // Assert
        Assert.AreEqual(Trend.Steady, trend);
    }

    [Test]
    public void ExtractTrend_Returns_Steady_When_Views_Are_All_Equal()
    {
        // Arrange
        TrendEvaluator trendEvaluator = new TrendEvaluator(5);
        List<int> views = new List<int> { 5, 5, 5, 5, 5 };

        // Act
        Trend trend = trendEvaluator.ExtractTrend(views);

        // Assert
        Assert.AreEqual(Trend.Steady, trend);
    }
}
