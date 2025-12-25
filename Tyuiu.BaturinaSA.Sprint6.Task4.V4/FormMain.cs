using System.Windows.Forms.VisualStyles;
using Tyuiu.BaturinaSA.Sprint6.Task4.V4.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task4.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void groupBoxInput_BSA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_BSA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox1.Text);
                int stop = Convert.ToInt32(textBox2.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array = ds.GetMassFunction(start, stop);
                this.chartFormula_BSA.Titles.Add("График функции F(x)");
                this.chartFormula_BSA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFormula_BSA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxConclusion_BSA.Text = "";
                chartFormula_BSA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFormula_BSA.Series[0].Points.AddXY(start + i, array[i]);
                    textBoxConclusion_BSA.AppendText(array[i] + Environment.NewLine);
                }
            }
            catch { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        

        private void buttonSave_BSA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxConclusion_BSA.Text);
                DialogResult dr = MessageBox.Show("Файл" + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch { MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    
        private void buttonInfo_BSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНБ-25-1 Батурина Софья Алексеевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxConclusion_BSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartFormula_BSA_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
