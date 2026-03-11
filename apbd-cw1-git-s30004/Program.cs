using apbd_cw1_git_s30004;

Console.WriteLine("Enter numbers separated by spaces:");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
    return;
}

var numbers = input.Split(' ')
    .Where(s => !string.IsNullOrWhiteSpace(s))
    .Select(int.Parse)
    .ToArray();

Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");