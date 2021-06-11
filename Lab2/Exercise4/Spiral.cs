using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Spiral
    {
        public void SpiralView(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            List<int> ans = new List<int>();
            int top = 0, left = 0, bot = row - 1, right = col - 1;
            while (ans.Count < row * col)
            {
                for (int i = left; i < right+1; i++)
                {
                    if (ans.Count < row * col)
                    {
                        //Console.WriteLine(matrix[top, i]);
                        ans.Add(matrix[top,i]);
                    }
                }
                top += 1;
                for (int j = top; j < bot+1; j++)
                {
                    if (ans.Count< row * col)
                    {
                        //Console.WriteLine(matrix[j, right]);
                        ans.Add(matrix[j, right]);
                    }
                }
                right -= 1;
                for (int k = right; k > left-1; k--)
                {
                    if (ans.Count < row * col)
                    {
                        //Console.WriteLine(matrix[bot, k]);
                        ans.Add(matrix[bot, k]);
                    }
                }
                bot -= 1;
                for (int l = bot; l > top - 1; l--)
                {
                    if (ans.Count < row * col)
                    {
                        //Console.WriteLine(matrix[l, left]);
                        ans.Add(matrix[l, left]);
                    }
                }
                left += 1;
            }

            foreach (int c in ans)
            {
                Console.Write(c + " ");
            }
        }
    }
}
