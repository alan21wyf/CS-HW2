using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given two integers A and B, returns the number of whole square within the interval [A, B].");
            Console.WriteLine("Enter the first Integer number A: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer number B: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Solution s = new Solution();
            int res = s.solution(first, second);
            Console.WriteLine($"The number of whole square within [{first}, {second}] is {res}.");
        }
    }
}
