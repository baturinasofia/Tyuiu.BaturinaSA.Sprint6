namespace Tyuiu.BaturinaSA.Sprint6.Task7.V22
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
            pictureBoxInfo_BSA = new PictureBox();
            textBoxInfo_BSA = new TextBox();
            buttonDone_BSA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_BSA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxInfo_BSA
            // 
            pictureBoxInfo_BSA.Image = (Image)resources.GetObject("pictureBoxInfo_BSA.Image");
            pictureBoxInfo_BSA.Location = new Point(25, 25);
            pictureBoxInfo_BSA.Name = "pictureBoxInfo_BSA";
            pictureBoxInfo_BSA.Size = new Size(258, 282);
            pictureBoxInfo_BSA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInfo_BSA.TabIndex = 0;
            pictureBoxInfo_BSA.TabStop = false;
            // 
            // textBoxInfo_BSA
            // 
            textBoxInfo_BSA.BackColor = Color.WhiteSmoke;
            textBoxInfo_BSA.Location = new Point(306, 25);
            textBoxInfo_BSA.Multiline = true;
            textBoxInfo_BSA.Name = "textBoxInfo_BSA";
            textBoxInfo_BSA.Size = new Size(462, 248);
            textBoxInfo_BSA.TabIndex = 1;
            textBoxInfo_BSA.Text = resources.GetString("textBoxInfo_BSA.Text");
            // 
            // buttonDone_BSA
            // 
            buttonDone_BSA.Location = new Point(648, 289);
            buttonDone_BSA.Name = "buttonDone_BSA";
            buttonDone_BSA.Size = new Size(120, 38);
            buttonDone_BSA.TabIndex = 2;
            buttonDone_BSA.Text = "Ок";
            buttonDone_BSA.UseVisualStyleBackColor = true;
            buttonDone_BSA.Click += buttonDone_BSA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 344);
            Controls.Add(buttonDone_BSA);
            Controls.Add(textBoxInfo_BSA);
            Controls.Add(pictureBoxInfo_BSA);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_BSA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxInfo_BSA;
        private TextBox textBoxInfo_BSA;
        private Button buttonDone_BSA;
    }
}