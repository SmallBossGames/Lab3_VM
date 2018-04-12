using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_VM;

namespace UnitTestProject1
{
    /// <summary>
    /// Сводное описание для UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        decimal[] inputValue3 = { -12.2327m, -14.2776m, -8.9511m, -0.1808m, 5.0256m };

        decimal[] output1 = { -15.846m, -10.98466m, -6.12332m, -1.26198m, 3.59936m };

        decimal Abs(decimal val) => val > 0 ? val : -val;

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SmoothMethod1()
        {
            var value = Smoothing.Smooth(5, inputValue3);
            decimal accuracy = 0.001m;

            for (int i = 0; i < value.Length; i++)
            { if (Abs(value[i] - output1[i]) > accuracy) Assert.Fail(Abs(value[i] - output1[i]).ToString()); }
        }
    }
}