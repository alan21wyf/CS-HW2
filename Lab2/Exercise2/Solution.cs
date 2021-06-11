using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public int solution(int[] A)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (count.ContainsKey(A[i]))
                {
                    count[A[i]] += 1;
                }
                else
                {
                    count.Add(A[i], 1);
                }
            }

            int max = -1;
            int num = 0;
            foreach (var val in count)
            {
                if (val.Value >= max)
                {
                    max = val.Value;
                    num = val.Key;
                }
            }

            return num;
        }
    }
}
