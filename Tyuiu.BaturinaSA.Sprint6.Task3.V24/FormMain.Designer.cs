namespace Tyuiu.BaturinaSA.Sprint6.Task3.V24
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
            groupBoxCondition_BSA = new GroupBox();
            dataGridViewResult_BSA = new DataGridView();
            textBox1 = new TextBox();
            buttonReference_BSA = new Button();
            buttonDone_BSA = new Button();
            groupBoxResult_BSA = new GroupBox();
            label1 = new Label();
            textBoxResult_BSA = new TextBox();
            groupBoxCondition_BSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BSA).BeginInit();
            groupBoxResult_BSA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_BSA
            // 
            groupBoxCondition_BSA.Controls.Add(dataGridViewResult_BSA);
            groupBoxCondition_BSA.Controls.Add(textBox1);
            groupBoxCondition_BSA.Location = new Point(3, 8);
            groupBoxCondition_BSA.Name = "groupBoxCondition_BSA";
            groupBoxCondition_BSA.Size = new Size(695, 421);
            groupBoxCondition_BSA.TabIndex = 0;
            groupBoxCondition_BSA.TabStop = false;
            groupBoxCondition_BSA.Text = "Условие";
            // 
            // dataGridViewResult_BSA
            // 
            dataGridViewResult_BSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BSA.Location = new Point(309, 30);
            dataGridViewResult_BSA.Name = "dataGridViewResult_BSA";
            dataGridViewResult_BSA.RowHeadersWidth = 62;
            dataGridViewResult_BSA.Size = new Size(360, 365);
            dataGridViewResult_BSA.TabIndex = 5;
            dataGridViewResult_BSA.CellContentClick += dataGridViewResult_BSA_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(3, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 355);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Заменить четные значения во второй строке на 0. \r\n-17  -6  10   5   3\r\n\r\n -10 -14  10  -7  -3\r\n\r\n -19   9   8 -17  -9\r\n\r\n -19  -5  -9 -18  14\r\n\r\n  17  12  11  12   2";
            // 
            // buttonReference_BSA
            // 
            buttonReference_BSA.Location = new Point(717, 359);
            buttonReference_BSA.Name = "buttonReference_BSA";
            buttonReference_BSA.Size = new Size(81, 70);
            buttonReference_BSA.TabIndex = 1;
            buttonReference_BSA.Text = "?";
            buttonReference_BSA.UseVisualStyleBackColor = true;
            buttonReference_BSA.Click += buttonReference_BSA_Click;
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.Location = new Point(804, 359);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(186, 70);
            buttonDone_BSA.TabIndex = 2;
            buttonDone_BSA.Text = "Выполнить";
            buttonDone_BSA.UseVisualStyleBackColor = true;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            // 
            // groupBoxResult_BSA
            // 
            groupBoxResult_BSA.Controls.Add(textBoxResult_BSA);
            groupBoxResult_BSA.Controls.Add(label1);
            groupBoxResult_BSA.Location = new Point(704, 21);
            groupBoxResult_BSA.Name = "groupBoxResult_BSA";
            groupBoxResult_BSA.Size = new Size(286, 217);
            groupBoxResult_BSA.TabIndex = 6;
            groupBoxResult_BSA.TabStop = false;
            groupBoxResult_BSA.Text = "Вывод данных";
            groupBoxResult_BSA.Enter += groupBoxResult_BSA_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Результат:";
            // 
            // textBoxResult_BSA
            // 
            textBoxResult_BSA.Location = new Point(6, 55);
            textBoxResult_BSA.Name = "textBoxResult_BSA";
            textBoxResult_BSA.Size = new Size(150, 31);
            textBoxResult_BSA.TabIndex = 1;
            textBoxResult_BSA.TextChanged += textBoxResult_BSA_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 450);
            Controls.Add(groupBoxResult_BSA);
            Controls.Add(buttonDone_BSA);
            Controls.Add(buttonReference_BSA);
            Controls.Add(groupBoxCondition_BSA);
            Name = "FormMain";
            Text = "Form1";
            groupBoxCondition_BSA.ResumeLayout(false);
            groupBoxCondition_BSA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BSA).EndInit();
            groupBoxResult_BSA.ResumeLayout(false);
            groupBoxResult_BSA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_BSA;
        private TextBox textBox1;
        private DataGridView dataGridViewResult_BSA;
        private Button buttonReference_BSA;
        private Button buttonDone_BSA;
        private GroupBox groupBoxResult_BSA;
        private TextBox textBoxResult_BSA;
        private Label label1;
    }
}
