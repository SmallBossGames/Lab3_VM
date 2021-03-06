﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_VM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N = 0;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(NTextBox.Text);
            dataGridView1.ColumnCount = N;
            dataGridView1.RowCount = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            decimal[,] truth = new decimal[2, N]; // строка, столбец
            string res = "L=";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < N; j++) truth[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            decimal h = (truth[0, 1] - truth[0, 0]) / 4.0m; // шаг

            var result = Interpolation.GetLagrange(truth);

            for (int i = 0; i < result.Length - 1; i++)
                res += result[i].ToString() + "x^" + (result.Length - 1 - i).ToString() + " + ";

            res += result[result.Length - 1];

            LagrangeTextBox.Text = res;

            for (int i = 0; i <= 4 * (N-1); i++)
                chart1.Series[0].Points.AddXY((truth[0, 0] + i * h), Interpolation.InterpolateLagrange(result, (truth[0, 0] + i * h)));
        }

        private void SplineButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            decimal[,] truth = new decimal[2, N];
            decimal[] result = new decimal[4 * N];
            string res = "";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < N; j++) truth[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            decimal h = (truth[0, 2] - truth[0, 1]) / 4; // шаг

            for (int i = 0; i <= 4 * (N-1); i++)
                result[i] = Interpolation.InterpolateSpline(truth, (truth[0, 0] + i * h));

            for (int i = 0; i < result.Length; i++)
                res += result[i].ToString() + " ";

            SplineTextBox.Text = res;

            for (int i = 0; i <= 4 * (N-1); i++)
                chart1.Series[0].Points.AddXY((truth[0, 0] + i * h), result[i]);
        }

        private void SmoothButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            decimal[] truth = new decimal[N];
            decimal[,] truh = new decimal[2, N];
            decimal[] result = new decimal[N];
            string res = "";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < N; j++) truh[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            for (int i = 0; i < N; i++) truth[i] = Convert.ToDecimal(dataGridView1[i, 1].Value);

            result = Smoothing.Smooth(N, truth);

            for (int i = 0; i < N; i++) res += result[i].ToString() + " ";

            SmoothTextBox.Text = res;

            for (int i = 0; i < N; i++) chart1.Series[0].Points.AddXY(truh[0, i], result[i]);
        }
    }
}