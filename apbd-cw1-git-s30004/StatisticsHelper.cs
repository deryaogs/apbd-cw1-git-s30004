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
}