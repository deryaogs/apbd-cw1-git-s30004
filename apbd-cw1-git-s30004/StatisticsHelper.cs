namespace apbd_cw1_git_s30004;

public static class StatisticsHelper
{
    public static int CalculateSum(int[] values)
    {
        int sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        return sum;
    }
    public static int CalculateCount(int[] values)
    {
        return values.Length;
    }
    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0) return 0;
        return (double)CalculateSum(values) / values.Length;
    }
    public static int CalculateMax(int[] values)
    {
        if (values.Length == 0) throw new ArgumentException("Array is empty");
        return values.Max();
    }
}

