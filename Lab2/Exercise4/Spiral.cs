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
            string ans = "";
            int top = 0, left = 0, bot = row - 1, right = col - 1;
            while (ans.Length < row * col)
            {
                for (int i = left; i < right+1; i++)
                {
                    if (ans.Length < row * col)
                    {
                        //Console.WriteLine(matrix[top, i]);
                        ans = ans + Convert.ToString(matrix[top,i]);
                    }
                }
                top += 1;
                for (int j = top; j < bot+1; j++)
                {
                    if (ans.Length < row*col)
                    {
                        //Console.WriteLine(matrix[j, right]);
                        ans = ans + Convert.ToString(matrix[j, right]);
                    }
                }
                right -= 1;
                for (int k = right; k > left-1; k--)
                {
                    if (ans.Length < row*col)
                    {
                        //Console.WriteLine(matrix[bot, k]);
                        ans = ans + Convert.ToString(matrix[bot, k]);
                    }
                }
                bot -= 1;
                for (int l = bot; l > top - 1; l--)
                {
                    if (ans.Length < row*col)
                    {
                        //Console.WriteLine(matrix[l, left]);
                        ans = ans + Convert.ToString(matrix[l, left]);
                    }
                }
                left += 1;
            }

            foreach (var c in ans)
            {
                Console.Write(c + " ");
            }
        }
    }
}
