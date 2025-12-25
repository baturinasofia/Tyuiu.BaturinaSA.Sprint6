using System.IO;
using Tyuiu.BaturinaSA.Sprint6.Task5.V21.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V21.txt";
        private void groupBoxTap_BSA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_BSA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                this.chartResult_BSA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_BSA.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult_BSA.Series[0].Points.Clear();

                dataGridViewResult_BSA.ColumnCount = 2;
                dataGridViewResult_BSA.Columns[0].Width = 20;
                dataGridViewResult_BSA.Columns[1].Width = 50;

                double[] numMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numMass.Length; i++)
                {
                    dataGridViewResult_BSA.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                    chartResult_BSA.Series[0].Points.AddXY(i, numMass[i]);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Произошла ошибка.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла Ошибка: {ex.Message}");
            }
        }
        

        private void buttonOpen_BSA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_BSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСТНб-25-1 Батурина Софья Алексеевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartResult_BSA_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
