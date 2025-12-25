namespace Tyuiu.BaturinaSA.Sprint6.Task4.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxInput_BSA = new GroupBox();
            buttonInfo_BSA = new Button();
            buttonSave_BSA = new Button();
            buttonDone_BSA = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBoxConclusion_BSA = new TextBox();
            chartFormula_BSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxInput_BSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFormula_BSA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInput_BSA
            // 
            groupBoxInput_BSA.Controls.Add(textBox2);
            groupBoxInput_BSA.Controls.Add(textBox1);
            groupBoxInput_BSA.Controls.Add(label1);
            groupBoxInput_BSA.Controls.Add(buttonDone_BSA);
            groupBoxInput_BSA.Controls.Add(buttonSave_BSA);
            groupBoxInput_BSA.Controls.Add(buttonInfo_BSA);
            groupBoxInput_BSA.Location = new Point(391, 12);
            groupBoxInput_BSA.Name = "groupBoxInput_BSA";
            groupBoxInput_BSA.Size = new Size(933, 121);
            groupBoxInput_BSA.TabIndex = 0;
            groupBoxInput_BSA.TabStop = false;
            groupBoxInput_BSA.Text = "groupBox1";
            groupBoxInput_BSA.Enter += groupBoxInput_BSA_Enter;
            // 
            // buttonInfo_BSA
            // 
            buttonInfo_BSA.Location = new Point(791, 37);
            buttonInfo_BSA.Name = "buttonInfo_BSA";
            buttonInfo_BSA.Size = new Size(112, 34);
            buttonInfo_BSA.TabIndex = 0;
            buttonInfo_BSA.Text = "Справка";
            buttonInfo_BSA.UseVisualStyleBackColor = true;
            buttonInfo_BSA.Click += buttonInfo_BSA_Click;
            // 
            // buttonSave_BSA
            // 
            buttonSave_BSA.Location = new Point(615, 46);
            buttonSave_BSA.Name = "buttonSave_BSA";
            buttonSave_BSA.Size = new Size(112, 34);
            buttonSave_BSA.TabIndex = 1;
            buttonSave_BSA.Text = "Сохранить";
            buttonSave_BSA.UseVisualStyleBackColor = true;
            buttonSave_BSA.Click += buttonSave_BSA_Click;
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.Location = new Point(497, 28);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(112, 34);
            buttonDone_BSA.TabIndex = 2;
            buttonDone_BSA.Text = "Выполнить";
            buttonDone_BSA.UseVisualStyleBackColor = true;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 3;
            label1.Text = "Старт и конец";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxConclusion_BSA
            // 
            textBoxConclusion_BSA.Location = new Point(12, 12);
            textBoxConclusion_BSA.Multiline = true;
            textBoxConclusion_BSA.Name = "textBoxConclusion_BSA";
            textBoxConclusion_BSA.Size = new Size(353, 588);
            textBoxConclusion_BSA.TabIndex = 6;
            textBoxConclusion_BSA.TextChanged += textBoxConclusion_BSA_TextChanged;
            // 
            // chartFormula_BSA
            // 
            chartArea3.Name = "ChartArea1";
            chartFormula_BSA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartFormula_BSA.Legends.Add(legend3);
            chartFormula_BSA.Location = new Point(381, 139);
            chartFormula_BSA.Name = "chartFormula_BSA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFormula_BSA.Series.Add(series3);
            chartFormula_BSA.Size = new Size(943, 450);
            chartFormula_BSA.TabIndex = 6;
            chartFormula_BSA.Text = "chart1";
            chartFormula_BSA.Click += chartFormula_BSA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 612);
            Controls.Add(chartFormula_BSA);
            Controls.Add(textBoxConclusion_BSA);
            Controls.Add(groupBoxInput_BSA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInput_BSA.ResumeLayout(false);
            groupBoxInput_BSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFormula_BSA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInput_BSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFormula_BSA;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button buttonDone_BSA;
        private Button buttonSave_BSA;
        private Button buttonInfo_BSA;
        private TextBox textBoxConclusion_BSA;
    }
}
