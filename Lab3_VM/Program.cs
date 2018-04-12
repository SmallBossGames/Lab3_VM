using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_VM
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            decimal[,] inputValue1 =
            {

            { -1, 0, 1, 2, 6, 10 },
            { 4, 2, 0, 1, 9, 5 }

            };

            decimal[,] inputValue2 =
            {

                { 0, 1, 2, 3 },
                { 0.0m, 0.5m, 2.0m, 1.5m }

            };

            decimal[] inputValue3 = { -12.2327m, -14.2776m, -8.9511m, -0.1808m, 5.0256m };

            var value = Interpolation.GetLagrange(inputValue1);

            var value2 = Interpolation.GetSplineCubeFull(inputValue2);

            var value3 = Smoothing.Smooth(5, inputValue3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}