using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_VM
{
    public static class Smoothing
    {
        public static decimal[] Smooth(int N, decimal[] input)
        {
            decimal[] W = new decimal[N];

            for (int i = 0; i < N - 1; i++)
            {
                if (i == 0) W[i] = 0.2m * (3 * input[0] + 2 * input[1] + input[2] - input[4]); // для первого
                else if (i == 1) W[i] = 0.1m * (4 * input[0] + 3 * input[1] + 2 * input[2] + input[3]); // для второго
                else if (i == N - 2) W[i] = 0.1m * (input[N - 4] + 2 * input[N - 3] + 3 * input[N - 2] + 4 * input[N - 1]); // для предпоследнего
                else if (i == N - 1) W[i] = 0.2m * (-input[N - 5] + input[N - 3] + 2 * input[N - 2] + 3 * input[N - 1]); // для последнего
                else W[i] = 0.2m * (input[i - 2] + input[i - 1] + input[i] + input[i + 1] + input[i + 2]); // для остального
            }

            return W;
        }
    }
}