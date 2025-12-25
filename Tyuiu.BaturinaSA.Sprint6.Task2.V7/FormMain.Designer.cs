namespace Tyuiu.BaturinaSA.Sprint6.Task2.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxInput_BSA = new GroupBox();
            textBoxStop_BSA = new TextBox();
            textBoxStart_BSA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonInfo_BSA = new Button();
            buttonDone_BSA = new Button();
            groupBoxConclusion_BSA = new GroupBox();
            chartFunction_BSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridList_BSA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBoxInput_BSA.SuspendLayout();
            groupBoxConclusion_BSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BSA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridList_BSA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 277);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 52);
            label2.Name = "label2";
            label2.Size = new Size(535, 25);
            label2.TabIndex = 1;
            label2.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(443, 25);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBoxInput_BSA
            // 
            groupBoxInput_BSA.Controls.Add(textBoxStop_BSA);
            groupBoxInput_BSA.Controls.Add(textBoxStart_BSA);
            groupBoxInput_BSA.Controls.Add(label4);
            groupBoxInput_BSA.Controls.Add(label3);
            groupBoxInput_BSA.Location = new Point(3, 279);
            groupBoxInput_BSA.Name = "groupBoxInput_BSA";
            groupBoxInput_BSA.Size = new Size(364, 171);
            groupBoxInput_BSA.TabIndex = 2;
            groupBoxInput_BSA.TabStop = false;
            groupBoxInput_BSA.Text = "Ввод данных";
            groupBoxInput_BSA.Enter += groupBoxInput_BSA_Enter;
            // 
            // textBoxStop_BSA
            // 
            textBoxStop_BSA.Location = new Point(200, 85);
            textBoxStop_BSA.Name = "textBoxStop_BSA";
            textBoxStop_BSA.Size = new Size(138, 31);
            textBoxStop_BSA.TabIndex = 4;
            textBoxStop_BSA.TextChanged += textBoxStop_BSA_TextChanged;
            // 
            // textBoxStart_BSA
            // 
            textBoxStart_BSA.Location = new Point(9, 85);
            textBoxStart_BSA.Name = "textBoxStart_BSA";
            textBoxStart_BSA.Size = new Size(137, 31);
            textBoxStart_BSA.TabIndex = 3;
            textBoxStart_BSA.TextChanged += textBoxStart_BSA_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 43);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 1;
            label4.Text = "Конец шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 42);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 0;
            label3.Text = "Старт шага:";
            // 
            // buttonInfo_BSA
            // 
            buttonInfo_BSA.BackColor = SystemColors.InactiveCaption;
            buttonInfo_BSA.Location = new Point(404, 299);
            buttonInfo_BSA.Name = "buttonInfo_BSA";
            buttonInfo_BSA.Size = new Size(159, 48);
            buttonInfo_BSA.TabIndex = 6;
            buttonInfo_BSA.Text = "Справка";
            buttonInfo_BSA.UseVisualStyleBackColor = false;
            buttonInfo_BSA.Click += buttonInfo_BSA_Click;
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.BackColor = SystemColors.AppWorkspace;
            buttonDone_BSA.Location = new Point(404, 353);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(159, 85);
            buttonDone_BSA.TabIndex = 7;
            buttonDone_BSA.Text = "Выполнить";
            buttonDone_BSA.UseVisualStyleBackColor = false;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            buttonDone_BSA.MouseEnter += groupBoxInput_BSA_Enter;
            buttonDone_BSA.MouseLeave += buttonDone_BSA_Click;
            // 
            // groupBoxConclusion_BSA
            // 
            groupBoxConclusion_BSA.Controls.Add(chartFunction_BSA);
            groupBoxConclusion_BSA.Controls.Add(dataGridList_BSA);
            groupBoxConclusion_BSA.Controls.Add(label5);
            groupBoxConclusion_BSA.Location = new Point(569, 12);
            groupBoxConclusion_BSA.Name = "groupBoxConclusion_BSA";
            groupBoxConclusion_BSA.Size = new Size(766, 426);
            groupBoxConclusion_BSA.TabIndex = 8;
            groupBoxConclusion_BSA.TabStop = false;
            groupBoxConclusion_BSA.Text = "Вывод данных";
            // 
            // chartFunction_BSA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BSA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BSA.Legends.Add(legend1);
            chartFunction_BSA.Location = new Point(187, 35);
            chartFunction_BSA.Name = "chartFunction_BSA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BSA.Series.Add(series1);
            chartFunction_BSA.Size = new Size(573, 369);
            chartFunction_BSA.TabIndex = 2;
            chartFunction_BSA.Click += chartFunction_BSA_Click;
            // 
            // dataGridList_BSA
            // 
            dataGridList_BSA.AllowUserToDeleteRows = false;
            dataGridList_BSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridList_BSA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridList_BSA.EnableHeadersVisualStyles = false;
            dataGridList_BSA.Location = new Point(11, 35);
            dataGridList_BSA.Name = "dataGridList_BSA";
            dataGridList_BSA.RowHeadersVisible = false;
            dataGridList_BSA.RowHeadersWidth = 62;
            dataGridList_BSA.Size = new Size(156, 369);
            dataGridList_BSA.TabIndex = 1;
            dataGridList_BSA.CellContentClick += dataGridList_BSA_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 27);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 0;
            label5.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 450);
            Controls.Add(groupBoxConclusion_BSA);
            Controls.Add(buttonDone_BSA);
            Controls.Add(buttonInfo_BSA);
            Controls.Add(groupBoxInput_BSA);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxInput_BSA.ResumeLayout(false);
            groupBoxInput_BSA.PerformLayout();
            groupBoxConclusion_BSA.ResumeLayout(false);
            groupBoxConclusion_BSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BSA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridList_BSA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxInput_BSA;
        private TextBox textBoxStop_BSA;
        private TextBox textBoxStart_BSA;
        private Label label4;
        private Label label3;
        private Button buttonInfo_BSA;
        private Button buttonDone_BSA;
        private GroupBox groupBoxConclusion_BSA;
        private DataGridView dataGridList_BSA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BSA;
    }
}
