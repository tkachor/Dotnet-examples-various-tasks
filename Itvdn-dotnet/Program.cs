using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Itvdn_dotnet
{
    
    class Program
    {
        static async Task Main(string[] args)
        {

            static IEnumerable<int> Nearest(int n)
            {
                int rowStart = 0;
                int colStart = 0;
                int rowEnd = 9;
                int colEnd = 9;

                int row = n / 10;
                int col = n % 10;

                if (row < rowStart || row > rowEnd
                    || col < colStart || col > colEnd)
                {
                    throw new ArgumentOutOfRangeException("Out of range");
                }

                if (row - 1 >= rowStart && col - 1 >= colStart)
                    yield return (row - 1) * 10 + (col - 1);
                if (row - 1 >= rowStart)
                    yield return (row - 1) * 10 + col;
                if (row - 1 >= rowStart && col + 1 <= colEnd)
                    yield return (row - 1) * 10 + (col + 1);
                if (col + 1 <= colEnd)
                    yield return row * 10 + (col + 1);
                if (row + 1 <= rowEnd && col + 1 <= colEnd)
                    yield return (row + 1) * 10 + (col + 1);
                if (row + 1 <= rowEnd)
                    yield return (row + 1) * 10 + col;
                if (row + 1 <= rowEnd && col - 1 >= colStart)
                    yield return (row + 1) * 10 + (col - 1);
                if (col - 1 >= colStart)
                    yield return row * 10 + (col - 1);
            }


            static IEnumerable<int> Nearest2(int n)
            {
                int[] range = { -1, 0, 1 };
                int d1 = n / 10, d2 = n % 10;
                int curr1, curr2;
                foreach (int i in range)
                {
                    curr1 = d1 + i;
                    if (curr1 < 0 || curr1 > 9) continue;
                    foreach (int j in range)
                    {
                        curr2 = d2 + j;
                        if (curr2 < 0 || curr2 > 9 || curr1 * 10 + curr2 == n) continue;
                        yield return curr1 * 10 + curr2;
                    }
                }
            }


            static IEnumerable<string> Queen(string q)
            {
                int x = q[0] - 96 - 1;
                int y = int.Parse(q[1].ToString()) - 1;

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (i == x && j != y)
                        {
                            yield return $"{(char)(96 + 1 + j)}{i + 1}";
                        }
                        if (j == y && i != x)
                        {
                            yield return $"{(char)(96 + 1 + j)}{i + 1}";
                        }
                        if ((x - i) == (y - j) || (i - x) == (j - y))
                        {
                            yield return $"{(char)(96 + 1 + j)}{i + 1}";
                        }
                    }
                }
            }

            static IEnumerable<string> Queen2(string q)
            {
                var dict = new Dictionary<int, string>{
                {1, "a"},
                {2, "b"},
                {3, "c"},
                {4, "d"},
                {5, "e"},
                {6, "f"},
                {7, "g"},
                {8, "h"}};

                int m = 7;
                int i = dict.FirstOrDefault(n => n.Value == q.Substring(0, 1)).Key;
                int j = int.Parse(q.Substring(1));

                for (int dx = (i > 1 ? -1 : 0); dx <= (i < m ? 1 : 0); ++dx)
                {
                    for (int dy = (j > 1 ? -1 : 0); dy <= (j < m ? 1 : 0); ++dy)
                    {
                        if (dx != 0 || dy != 0)
                            yield return dict[i + dx] + (j + dy).ToString();
                    }
                }
            }


        }

       
    }
}
