using System;
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
            decimal[,] truth = new decimal[2, N]; // строка, столбец
            decimal[] result = new decimal[N];
            string res = "L=";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < N; j++) truth[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            result = Interpolation.GetLagrange(truth);

            for (int i = 0; i < result.Length; i++) res += result[i].ToString() + "x^" + (result.Length - i).ToString() + " + ";

            LagrangeTextBox.Text = res;
        }

        private void SplineButton_Click(object sender, EventArgs e)
        {
            decimal[,] truth = new decimal[2, N];
            decimal[] result = new decimal[N];
            string res = "";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < N; j++) truth[i, j] = Convert.ToDecimal(dataGridView1[j, i].Value);
            }

            for (int i = 0; i < N; i++) result[i] = Interpolation.InterpolateSpline(truth, truth[0, i]);

            for (int i = 0; i < result.Length; i++) res += result[i].ToString() + " ";

            SplineTextBox.Text = res;
        }

        private void SmoothButton_Click(object sender, EventArgs e)
        {
            decimal[] truth = new decimal[N];
            decimal[] result = new decimal[N];
            string res = "";

            for (int i = 0; i < N; i++) truth[i] = Convert.ToDecimal(dataGridView1[i, 0].Value);

            result = Smoothing.Smooth(N, truth);

            for (int i = 0; i < N; i++) res += result[i].ToString() + " ";

            SmoothTextBox.Text = res;
        }
    }
}