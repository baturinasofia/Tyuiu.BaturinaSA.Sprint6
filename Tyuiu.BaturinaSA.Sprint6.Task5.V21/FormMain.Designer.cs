namespace Tyuiu.BaturinaSA.Sprint6.Task5.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTap_BSA = new GroupBox();
            buttonHelp_BSA = new Button();
            buttonOpen_BSA = new Button();
            buttonDone_BSA = new Button();
            dataGridViewResult_BSA = new DataGridView();
            chartResult_BSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTap_BSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BSA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_BSA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTap_BSA
            // 
            groupBoxTap_BSA.Controls.Add(buttonHelp_BSA);
            groupBoxTap_BSA.Controls.Add(buttonOpen_BSA);
            groupBoxTap_BSA.Controls.Add(buttonDone_BSA);
            groupBoxTap_BSA.Location = new Point(0, 0);
            groupBoxTap_BSA.Name = "groupBoxTap_BSA";
            groupBoxTap_BSA.Size = new Size(516, 150);
            groupBoxTap_BSA.TabIndex = 0;
            groupBoxTap_BSA.TabStop = false;
            groupBoxTap_BSA.Text = "groupBox1";
            groupBoxTap_BSA.Enter += groupBoxTap_BSA_Enter;
            // 
            // buttonHelp_BSA
            // 
            buttonHelp_BSA.Location = new Point(369, 56);
            buttonHelp_BSA.Name = "buttonHelp_BSA";
            buttonHelp_BSA.Size = new Size(112, 34);
            buttonHelp_BSA.TabIndex = 2;
            buttonHelp_BSA.Text = "Справка";
            buttonHelp_BSA.UseVisualStyleBackColor = true;
            buttonHelp_BSA.Click += buttonHelp_BSA_Click;
            // 
            // buttonOpen_BSA
            // 
            buttonOpen_BSA.Location = new Point(211, 56);
            buttonOpen_BSA.Name = "buttonOpen_BSA";
            buttonOpen_BSA.Size = new Size(112, 34);
            buttonOpen_BSA.TabIndex = 1;
            buttonOpen_BSA.Text = "Открыть";
            buttonOpen_BSA.UseVisualStyleBackColor = true;
            buttonOpen_BSA.Click += buttonOpen_BSA_Click;
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.Location = new Point(69, 56);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(112, 34);
            buttonDone_BSA.TabIndex = 0;
            buttonDone_BSA.Text = "Выполнить";
            buttonDone_BSA.UseVisualStyleBackColor = true;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            // 
            // dataGridViewResult_BSA
            // 
            dataGridViewResult_BSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BSA.Location = new Point(12, 156);
            dataGridViewResult_BSA.Name = "dataGridViewResult_BSA";
            dataGridViewResult_BSA.RowHeadersWidth = 62;
            dataGridViewResult_BSA.Size = new Size(504, 339);
            dataGridViewResult_BSA.TabIndex = 3;
            // 
            // chartResult_BSA
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_BSA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_BSA.Legends.Add(legend2);
            chartResult_BSA.Location = new Point(567, 24);
            chartResult_BSA.Name = "chartResult_BSA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult_BSA.Series.Add(series2);
            chartResult_BSA.Size = new Size(740, 450);
            chartResult_BSA.TabIndex = 4;
            chartResult_BSA.Text = "chart1";
            chartResult_BSA.Click += chartResult_BSA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 498);
            Controls.Add(chartResult_BSA);
            Controls.Add(dataGridViewResult_BSA);
            Controls.Add(groupBoxTap_BSA);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTap_BSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BSA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_BSA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTap_BSA;
        private Button buttonHelp_BSA;
        private Button buttonOpen_BSA;
        private Button buttonDone_BSA;
        private DataGridView dataGridViewResult_BSA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BSA;
    }
}
