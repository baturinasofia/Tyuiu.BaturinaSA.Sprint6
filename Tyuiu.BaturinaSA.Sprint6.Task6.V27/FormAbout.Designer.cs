namespace Tyuiu.BaturinaSA.Sprint6.Task6.V27
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            textBox = new TextBox();
            buttonOk_BSA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox
            // 
            textBox.BackColor = Color.WhiteSmoke;
            textBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(250, 21);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(382, 288);
            textBox.TabIndex = 1;
            textBox.Text = resources.GetString("textBox.Text");
            // 
            // buttonOk_BSA
            // 
            buttonOk_BSA.Location = new Point(497, 266);
            buttonOk_BSA.Name = "buttonOk_BSA";
            buttonOk_BSA.Size = new Size(112, 34);
            buttonOk_BSA.TabIndex = 2;
            buttonOk_BSA.Text = "Ok";
            buttonOk_BSA.UseVisualStyleBackColor = true;
            buttonOk_BSA.Click += buttonOk_BSA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 321);
            Controls.Add(buttonOk_BSA);
            Controls.Add(textBox);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox;
        private Button buttonOk_BSA;
    }
}