using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_VM
{
    public static class Interpolation
    {
        
        public static decimal[] GetLagrange(decimal[,] inputTable)
        {
            if (inputTable.GetLength(0) != 2) throw new FormatException();

            var length = inputTable.GetLength(1);

            decimal[] outArray = null;

            for (int i = 0; i < length; i++)
            {
                var value = GetLagrangeKoeff(inputTable, i);

                if (outArray == null)
                {
                    outArray = value;
                }
                else
                {
                    for (int j = 0; j < length; j++)
                    {
                        outArray[j] += value[j];
                    }
                }
            }

            return outArray;
        }

        private static decimal[] GetLagrangeKoeff(decimal[,] inputTable, int i)
        {
            if (inputTable.GetLength(0) != 2) throw new FormatException();
            var length = inputTable.GetLength(1);


            var outArray = new decimal[length];

            var koeffNumber = 0;
            outArray[0] = 1;

            for (int j = 0; j < length; j++)
            {
                if (i == j) continue;

                koeffNumber++;

                for (int k = koeffNumber-1; k >= 0; k--)
                {
                    outArray[k + 1] -= outArray[k] * inputTable[0, j];
                }
            }

            var koeff = inputTable[1,i];

            for (int j = 0; j < length; j++)
            {
                if (i == j) continue;

                koeff /= (inputTable[0, i] - inputTable[0, j]);
            }

            for (int j = 0; j < length; j++)
            {
                outArray[j] *= koeff;
            }

            return outArray;
        }

       // private static decimal[] SumArray => throw new NotImplementedException();
    }
}
