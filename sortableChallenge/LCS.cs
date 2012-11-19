using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace sortableChallenge
{
    class LCS
    {
        public static int lcs(ArrayList x, ArrayList y)
        {
            int n = x.Count;
            int m = y.Count;
            int[,] table = new int[n + 1, m + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        table[i, j] = 0;
                    }
                    else if (x[i - 1].ToString().Trim().ToLower() == y[j - 1].ToString().Trim().ToLower())
                        table[i, j] = table[i - 1, j - 1] + 1;
                    else
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                }
            }
            return table[n, m];
        }

        public static double normalized_lcs(string x_, string y_)
        {
            ArrayList x = convert(x_);
            ArrayList y = convert(y_);

            int n = x.Count;
            int m = y.Count;
            int[,] table = new int[n + 1, m + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        table[i, j] = 0;
                    }
                    else if (x[i - 1].ToString().Trim().ToLower() == y[j - 1].ToString().Trim().ToLower())
                        table[i, j] = table[i - 1, j - 1] + 1;
                    else
                        table[i, j] = Math.Max(table[i - 1, j], table[i, j - 1]);
                }
            }
            return (Convert.ToDouble(table[n, m]) * Convert.ToDouble(table[n, m]))/(Convert.ToDouble(x.Count) * Convert.ToDouble(y.Count));
        }

        public static ArrayList convert(string x)
        {
            ArrayList res = new ArrayList();
            string[] xs = x.Split(' ');
            for (int i = 0; i < xs.Length; i++)
                res.Add(xs[i]);
            return res;
        }
    }
}
