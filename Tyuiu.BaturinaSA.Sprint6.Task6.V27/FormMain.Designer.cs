namespace Tyuiu.BaturinaSA.Sprint6.Task6.V27
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
            components = new System.ComponentModel.Container();
            textBoxInput_BSA = new TextBox();
            textBoxConclusion_BSA = new TextBox();
            openFileDialog_BSA = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            buttonDone_BSA = new Button();
            buttonOpenFiled_BSA = new Button();
            buttonHelp_BSA = new Button();
            splitContainerPanel_BSA = new SplitContainer();
            button1 = new Button();
            groupBoxInput_BSA = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainerPanel_BSA).BeginInit();
            splitContainerPanel_BSA.SuspendLayout();
            groupBoxInput_BSA.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput_BSA
            // 
            textBoxInput_BSA.Location = new Point(9, 30);
            textBoxInput_BSA.Multiline = true;
            textBoxInput_BSA.Name = "textBoxInput_BSA";
            textBoxInput_BSA.Size = new Size(429, 353);
            textBoxInput_BSA.TabIndex = 0;
            textBoxInput_BSA.TextChanged += textBoxInput_BSA_TextChanged;
            // 
            // textBoxConclusion_BSA
            // 
            textBoxConclusion_BSA.Location = new Point(520, 15);
            textBoxConclusion_BSA.Multiline = true;
            textBoxConclusion_BSA.Name = "textBoxConclusion_BSA";
            textBoxConclusion_BSA.Size = new Size(408, 368);
            textBoxConclusion_BSA.TabIndex = 1;
            textBoxConclusion_BSA.TextChanged += textBoxConclusion_BSA_TextChanged;
            // 
            // openFileDialog_BSA
            // 
            openFileDialog_BSA.FileName = "openFileDialog_BSA";
            openFileDialog_BSA.FileOk += openFileDialog_BSA_FileOk;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.Location = new Point(34, 157);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(112, 34);
            buttonDone_BSA.TabIndex = 2;
            buttonDone_BSA.Text = "button1";
            buttonDone_BSA.UseVisualStyleBackColor = true;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            // 
            // buttonOpenFiled_BSA
            // 
            buttonOpenFiled_BSA.Location = new Point(152, 157);
            buttonOpenFiled_BSA.Name = "buttonOpenFiled_BSA";
            buttonOpenFiled_BSA.Size = new Size(112, 34);
            buttonOpenFiled_BSA.TabIndex = 3;
            buttonOpenFiled_BSA.Text = "button1";
            buttonOpenFiled_BSA.UseVisualStyleBackColor = true;
            buttonOpenFiled_BSA.Click += buttonOpenFiled_BSA_Click;
            // 
            // buttonHelp_BSA
            // 
            buttonHelp_BSA.Location = new Point(50, 224);
            buttonHelp_BSA.Name = "buttonHelp_BSA";
            buttonHelp_BSA.Size = new Size(112, 34);
            buttonHelp_BSA.TabIndex = 4;
            buttonHelp_BSA.Text = "button1";
            buttonHelp_BSA.UseVisualStyleBackColor = true;
            buttonHelp_BSA.Click += buttonHelp_BSA_Click;
            // 
            // splitContainerPanel_BSA
            // 
            splitContainerPanel_BSA.Location = new Point(12, 12);
            splitContainerPanel_BSA.Name = "splitContainerPanel_BSA";
            // 
            // splitContainerPanel_BSA.Panel2
            // 
            splitContainerPanel_BSA.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainerPanel_BSA.Size = new Size(225, 150);
            splitContainerPanel_BSA.SplitterDistance = 75;
            splitContainerPanel_BSA.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(230, 52);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxInput_BSA
            // 
            groupBoxInput_BSA.Controls.Add(textBoxInput_BSA);
            groupBoxInput_BSA.Controls.Add(textBoxConclusion_BSA);
            groupBoxInput_BSA.Location = new Point(339, 12);
            groupBoxInput_BSA.Name = "groupBoxInput_BSA";
            groupBoxInput_BSA.Size = new Size(982, 409);
            groupBoxInput_BSA.TabIndex = 6;
            groupBoxInput_BSA.TabStop = false;
            groupBoxInput_BSA.Text = "groupBoxInput_BSA";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 450);
            Controls.Add(groupBoxInput_BSA);
            Controls.Add(button1);
            Controls.Add(splitContainerPanel_BSA);
            Controls.Add(buttonHelp_BSA);
            Controls.Add(buttonOpenFiled_BSA);
            Controls.Add(buttonDone_BSA);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)splitContainerPanel_BSA).EndInit();
            splitContainerPanel_BSA.ResumeLayout(false);
            groupBoxInput_BSA.ResumeLayout(false);
            groupBoxInput_BSA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxInput_BSA;
        private TextBox textBoxConclusion_BSA;
        private OpenFileDialog openFileDialog_BSA;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonDone_BSA;
        private Button buttonOpenFiled_BSA;
        private Button buttonHelp_BSA;
        private SplitContainer splitContainerPanel_BSA;
        private Button button1;
        private GroupBox groupBoxInput_BSA;
    }
}
