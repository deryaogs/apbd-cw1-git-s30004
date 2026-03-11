using apbd_cw1_git_s30004;

Console.WriteLine("Enter numbers separated by spaces:");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
    return;
}

try
{
    var numbers = input.Split(' ')
        .Where(s => !string.IsNullOrWhiteSpace(s))
        .Select(s => 
        {
            if (!int.TryParse(s, out var num))
            {
                throw new FormatException($"Invalid number: {s}");
            }
            return num;
        })
        .ToArray();
    Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}