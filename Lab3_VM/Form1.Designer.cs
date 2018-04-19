namespace Lab3_VM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LagrangeTextBox = new System.Windows.Forms.TextBox();
            this.SplineButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SplineTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SmoothTextBox = new System.Windows.Forms.TextBox();
            this.SmoothButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество столбцов:";
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(178, 6);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 20);
            this.NTextBox.TabIndex = 2;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(284, 6);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 23);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Ввести";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Получить многочлен Лагранжа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Многочлен Лагранжа: ";
            // 
            // LagrangeTextBox
            // 
            this.LagrangeTextBox.Location = new System.Drawing.Point(140, 348);
            this.LagrangeTextBox.Name = "LagrangeTextBox";
            this.LagrangeTextBox.Size = new System.Drawing.Size(469, 20);
            this.LagrangeTextBox.TabIndex = 6;
            // 
            // SplineButton
            // 
            this.SplineButton.Location = new System.Drawing.Point(615, 64);
            this.SplineButton.Name = "SplineButton";
            this.SplineButton.Size = new System.Drawing.Size(173, 23);
            this.SplineButton.TabIndex = 7;
            this.SplineButton.Text = "Сплайн";
            this.SplineButton.UseVisualStyleBackColor = true;
            this.SplineButton.Click += new System.EventHandler(this.SplineButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сплайн-интерполяция: ";
            // 
            // SplineTextBox
            // 
            this.SplineTextBox.Location = new System.Drawing.Point(140, 380);
            this.SplineTextBox.Name = "SplineTextBox";
            this.SplineTextBox.Size = new System.Drawing.Size(469, 20);
            this.SplineTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сглаживание: ";
            // 
            // SmoothTextBox
            // 
            this.SmoothTextBox.Location = new System.Drawing.Point(96, 408);
            this.SmoothTextBox.Name = "SmoothTextBox";
            this.SmoothTextBox.Size = new System.Drawing.Size(469, 20);
            this.SmoothTextBox.TabIndex = 11;
            // 
            // SmoothButton
            // 
            this.SmoothButton.Location = new System.Drawing.Point(615, 93);
            this.SmoothButton.Name = "SmoothButton";
            this.SmoothButton.Size = new System.Drawing.Size(173, 23);
            this.SmoothButton.TabIndex = 12;
            this.SmoothButton.Text = "Сглаживание";
            this.SmoothButton.UseVisualStyleBackColor = true;
            this.SmoothButton.Click += new System.EventHandler(this.SmoothButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(615, 124);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 608);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SmoothButton);
            this.Controls.Add(this.SmoothTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SplineTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SplineButton);
            this.Controls.Add(this.LagrangeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LagrangeTextBox;
        private System.Windows.Forms.Button SplineButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SplineTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SmoothTextBox;
        private System.Windows.Forms.Button SmoothButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

