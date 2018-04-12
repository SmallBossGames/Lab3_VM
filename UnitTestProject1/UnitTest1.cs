using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_VM;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        decimal[,] inputValue1 =
        {
            { -1, 0, 1, 2 },
            { 4, 2, 0, 1 }
        };

        decimal[] output1 = { 1m / 2, 0, -5m / 2, 2m };

        decimal[,] inputValue2 =
{
            { 0, 1, 2, 3 },
            { 0.0m, 0.5m, 2.0m, 1.5m }
        };

        decimal[] outputSpline2 = { 2.4m, -3.6m };

        decimal Abs(decimal val) => val > 0 ? val : -val;

        [TestMethod]
        public void LagrangeTest1()
        {
            var value = Interpolation.GetLagrange(inputValue1);
            var accuracy = 0.001m;

            for (int i = 0; i < value.Length; i++)
            {
                if (Abs(value[i] - output1[i]) > accuracy) Assert.Fail(Abs(value[i] - output1[i]).ToString());
            }

        }

        [TestMethod]
        public void SplineTest1()
        {
            var value = Interpolation.GetSplineCube(inputValue2);
            var accuracy = 0.001m;

            for (int i = 0; i < value.Length; i++)
            {
                if (Abs(value[i] - outputSpline2[i]) > accuracy) Assert.Fail(Abs(value[i] - outputSpline2[i]).ToString());
            }

        }
    }
}
