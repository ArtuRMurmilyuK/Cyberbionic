int[] nums = new int[4];

try
{
    nums[5] = 1;
}
catch(Exception ex)
{
    Console.WriteLine($"Error occured: {ex.Message}");
}