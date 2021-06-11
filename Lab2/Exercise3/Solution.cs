using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            int res = 0;
            for (int i = A; i <= B; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}
