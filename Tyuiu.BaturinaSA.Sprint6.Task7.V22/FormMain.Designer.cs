namespace Tyuiu.BaturinaSA.Sprint6.Task7.V22
{
    partial class FormMainTask_BSA
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTask_BSA));
            groupBoxTap_BSA = new GroupBox();
            buttonHelp_BSA = new Button();
            buttonSaveFileDialoge_BSA = new Button();
            buttonOpenFileDialoge_BSA = new Button();
            buttonDone_BSA = new Button();
            groupBoxCondition_BSA = new GroupBox();
            textBoxTask_BSA = new TextBox();
            groupBoxInput_BSA = new GroupBox();
            dataGridViewIn_BSA = new DataGridView();
            groupBoxResult_BSA = new GroupBox();
            dataGridViewOut_BSA = new DataGridView();
            openFileDialogTask_BSA = new OpenFileDialog();
            saveFileDialogTask_BSA = new SaveFileDialog();
            toolTipTask_BSA = new ToolTip(components);
            groupBoxTap_BSA.SuspendLayout();
            groupBoxCondition_BSA.SuspendLayout();
            groupBoxInput_BSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BSA).BeginInit();
            groupBoxResult_BSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BSA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTap_BSA
            // 
            groupBoxTap_BSA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTap_BSA.Controls.Add(buttonHelp_BSA);
            groupBoxTap_BSA.Controls.Add(buttonSaveFileDialoge_BSA);
            groupBoxTap_BSA.Controls.Add(buttonOpenFileDialoge_BSA);
            groupBoxTap_BSA.Controls.Add(buttonDone_BSA);
            groupBoxTap_BSA.Location = new Point(10, 10);
            groupBoxTap_BSA.Name = "groupBoxTap_BSA";
            groupBoxTap_BSA.Size = new Size(1143, 115);
            groupBoxTap_BSA.TabIndex = 0;
            groupBoxTap_BSA.TabStop = false;
            // 
            // buttonHelp_BSA
            // 
            buttonHelp_BSA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BSA.Image = (Image)resources.GetObject("buttonHelp_BSA.Image");
            buttonHelp_BSA.Location = new Point(1030, 21);
            buttonHelp_BSA.Name = "buttonHelp_BSA";
            buttonHelp_BSA.Size = new Size(112, 88);
            buttonHelp_BSA.TabIndex = 5;
            buttonHelp_BSA.UseVisualStyleBackColor = true;
            buttonHelp_BSA.Click += buttonHelp_BSA_Click;
            buttonHelp_BSA.MouseEnter += buttonHelp_BSA_MouseEnter;
            // 
            // buttonSaveFileDialoge_BSA
            // 
            buttonSaveFileDialoge_BSA.Enabled = false;
            buttonSaveFileDialoge_BSA.FlatStyle = FlatStyle.Flat;
            buttonSaveFileDialoge_BSA.Image = (Image)resources.GetObject("buttonSaveFileDialoge_BSA.Image");
            buttonSaveFileDialoge_BSA.Location = new Point(252, 21);
            buttonSaveFileDialoge_BSA.Name = "buttonSaveFileDialoge_BSA";
            buttonSaveFileDialoge_BSA.Size = new Size(112, 88);
            buttonSaveFileDialoge_BSA.TabIndex = 4;
            buttonSaveFileDialoge_BSA.UseVisualStyleBackColor = true;
            buttonSaveFileDialoge_BSA.Click += buttonSaveFileDialoge_BSA_Click;
            buttonSaveFileDialoge_BSA.MouseEnter += buttonSaveFileDialoge_BSA_MouseEnter;
            // 
            // buttonOpenFileDialoge_BSA
            // 
            buttonOpenFileDialoge_BSA.Image = (Image)resources.GetObject("buttonOpenFileDialoge_BSA.Image");
            buttonOpenFileDialoge_BSA.Location = new Point(12, 21);
            buttonOpenFileDialoge_BSA.Name = "buttonOpenFileDialoge_BSA";
            buttonOpenFileDialoge_BSA.Size = new Size(112, 88);
            buttonOpenFileDialoge_BSA.TabIndex = 3;
            buttonOpenFileDialoge_BSA.UseVisualStyleBackColor = true;
            buttonOpenFileDialoge_BSA.Click += buttonOpenFileDialoge_BSA_Click;
            buttonOpenFileDialoge_BSA.MouseEnter += buttonOpenFileDialoge_BSA_MouseEnter;
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.Enabled = false;
            buttonDone_BSA.FlatStyle = FlatStyle.Flat;
            buttonDone_BSA.Image = (Image)resources.GetObject("buttonDone_BSA.Image");
            buttonDone_BSA.Location = new Point(130, 21);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(116, 88);
            buttonDone_BSA.TabIndex = 2;
            buttonDone_BSA.UseVisualStyleBackColor = true;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            buttonDone_BSA.DragEnter += buttonDone_BSA_DragEnter;
            // 
            // groupBoxCondition_BSA
            // 
            groupBoxCondition_BSA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCondition_BSA.Controls.Add(textBoxTask_BSA);
            groupBoxCondition_BSA.Location = new Point(0, 121);
            groupBoxCondition_BSA.Name = "groupBoxCondition_BSA";
            groupBoxCondition_BSA.Size = new Size(1153, 101);
            groupBoxCondition_BSA.TabIndex = 0;
            groupBoxCondition_BSA.TabStop = false;
            groupBoxCondition_BSA.Text = "Условие";
            // 
            // textBoxTask_BSA
            // 
            textBoxTask_BSA.BackColor = Color.WhiteSmoke;
            textBoxTask_BSA.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BSA.Location = new Point(12, 23);
            textBoxTask_BSA.Multiline = true;
            textBoxTask_BSA.Name = "textBoxTask_BSA";
            textBoxTask_BSA.Size = new Size(1130, 72);
            textBoxTask_BSA.TabIndex = 6;
            textBoxTask_BSA.Text = resources.GetString("textBoxTask_BSA.Text");
            // 
            // groupBoxInput_BSA
            // 
            groupBoxInput_BSA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_BSA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxInput_BSA.Controls.Add(dataGridViewIn_BSA);
            groupBoxInput_BSA.Location = new Point(0, 228);
            groupBoxInput_BSA.Margin = new Padding(10);
            groupBoxInput_BSA.Name = "groupBoxInput_BSA";
            groupBoxInput_BSA.Size = new Size(558, 344);
            groupBoxInput_BSA.TabIndex = 0;
            groupBoxInput_BSA.TabStop = false;
            groupBoxInput_BSA.Text = "Ввод:";
            // 
            // dataGridViewIn_BSA
            // 
            dataGridViewIn_BSA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewIn_BSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_BSA.Location = new Point(12, 30);
            dataGridViewIn_BSA.Margin = new Padding(10);
            dataGridViewIn_BSA.Name = "dataGridViewIn_BSA";
            dataGridViewIn_BSA.RowHeadersWidth = 62;
            dataGridViewIn_BSA.Size = new Size(529, 256);
            dataGridViewIn_BSA.TabIndex = 2;
            dataGridViewIn_BSA.CellContentClick += dataGridViewIn_BSA_CellContentClick;
            // 
            // groupBoxResult_BSA
            // 
            groupBoxResult_BSA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxResult_BSA.Controls.Add(dataGridViewOut_BSA);
            groupBoxResult_BSA.Location = new Point(593, 228);
            groupBoxResult_BSA.Margin = new Padding(10);
            groupBoxResult_BSA.Name = "groupBoxResult_BSA";
            groupBoxResult_BSA.Size = new Size(549, 351);
            groupBoxResult_BSA.TabIndex = 1;
            groupBoxResult_BSA.TabStop = false;
            groupBoxResult_BSA.Text = "Вывод:";
            // 
            // dataGridViewOut_BSA
            // 
            dataGridViewOut_BSA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewOut_BSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_BSA.Location = new Point(13, 30);
            dataGridViewOut_BSA.Margin = new Padding(10);
            dataGridViewOut_BSA.Name = "dataGridViewOut_BSA";
            dataGridViewOut_BSA.RowHeadersWidth = 62;
            dataGridViewOut_BSA.Size = new Size(523, 256);
            dataGridViewOut_BSA.TabIndex = 3;
            dataGridViewOut_BSA.CellContentClick += dataGridViewOut_BSA_CellContentClick;
            // 
            // openFileDialogTask_BSA
            // 
            openFileDialogTask_BSA.FileName = "openFileDialog1";
            // 
            // toolTipTask_BSA
            // 
            toolTipTask_BSA.IsBalloon = true;
            toolTipTask_BSA.ToolTipTitle = "Подсказка";
            toolTipTask_BSA.Popup += toolTipTask_BSA_Popup;
            // 
            // FormMainTask_BSA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 584);
            Controls.Add(groupBoxInput_BSA);
            Controls.Add(groupBoxResult_BSA);
            Controls.Add(groupBoxCondition_BSA);
            Controls.Add(groupBoxTap_BSA);
            Name = "FormMainTask_BSA";
            Text = "Спринт 6 | Таск 7 | Вариант 22 | Батурина С.А.";
            WindowState = FormWindowState.Maximized;
            groupBoxTap_BSA.ResumeLayout(false);
            groupBoxCondition_BSA.ResumeLayout(false);
            groupBoxCondition_BSA.PerformLayout();
            groupBoxInput_BSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BSA).EndInit();
            groupBoxResult_BSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BSA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTap_BSA;
        private GroupBox groupBoxCondition_BSA;
        private GroupBox groupBoxInput_BSA;
        private GroupBox groupBoxResult_BSA;
        private OpenFileDialog openFileDialogTask_BSA;
        private Button buttonDone_BSA;
        private SaveFileDialog saveFileDialogTask_BSA;
        private ToolTip toolTipTask_BSA;
        private Button buttonHelp_BSA;
        private Button buttonSaveFileDialoge_BSA;
        private Button buttonOpenFileDialoge_BSA;
        private TextBox textBoxTask_BSA;
        private DataGridView dataGridViewIn_BSA;
        private DataGridView dataGridViewOut_BSA;
    }
}
