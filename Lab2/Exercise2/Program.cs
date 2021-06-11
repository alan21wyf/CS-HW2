using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the array values, separated by a space (For example, enter '5 2 3 6'):");
            string[] arr = Console.ReadLine().Split(" ");
            int[] nums = new int[size];
            int idx = 0;
            foreach (string val in arr)
            {
                nums[idx] = Convert.ToInt32(val);
                idx += 1;
            }
            Solution s = new Solution();
            int max = s.solution(nums);
            Console.WriteLine($"\nThe most often value in the array is {max}.");
        }
    }
}
