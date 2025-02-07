using System;

class Program
{
    static int Sum(List<int> nums, int a = 0, int sum = 0)
    {
        if (nums.Count == a)
        {
            return sum;
        }
        sum += nums[a];
        a++;
        return Sum(nums, a, sum);
    }
    static void Main()
    {
        List<int> nums = new List<int>();
        nums.AddRange(1, 2, 3, 4, 4, 5);
        System.Console.WriteLine(Sum(nums));
    }
}