namespace BusinessLogic;

// Define an enum to represent the possible trends
public enum Trend { Down, Up, Steady }

// Define a class to evaluate trends based on a minimum jump threshold
public class TrendEvaluator
{
    private int minJump; // Minimum jump threshold for trend evaluation

    // Constructor to initialize the TrendEvaluator with a minimum jump threshold
    public TrendEvaluator(int minJump)
    {
        this.minJump = minJump;
    }

    // Method to extract the trend from a list of views
    public Trend ExtractTrend(List<int> views)
    {
        int ups = 0, downs = 0; // Initialize counters for upward and downward trends

        // Iterate through the views to analyze trends
        for (int i = 1; i < views.Count; i++)
        {
            // Check if the difference between consecutive views is greater than the minimum jump threshold
            if (views[i - 1] - minJump > views[i]) // If the difference is greater than minJump, it's a downward trend
            {
                downs++; // Increment the downward trend counter
            }
            else if (views[i - 1] + minJump < views[i]) // If the difference is less than minJump, it's an upward trend
            {
                ups++; // Increment the upward trend counter
            }
        }

        // Determine the overall trend based on the counts of ups and downs
        if (ups > downs) // If there are more upward trends than downward trends
        {
            return Trend.Up; // Return Up trend
        }
        else if (downs > ups) // If there are more downward trends than upward trends
        {
            return Trend.Down; // Return Down trend
        }
        else // If the counts of ups and downs are equal
        {
            return Trend.Steady; // Return Steady trend
        }
    }
}
