using Tyuiu.BaturinaSA.Sprint6.Task2.V7.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBoxInput_BSA_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStart_BSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStop_BSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_BSA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BSA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_BSA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_BSA.Titles.Add("График функции 3x + 2 - ((2x-x)/(cosx +1)) ");
                this.chartFunction_BSA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BSA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridList_BSA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_BSA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridList_BSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartFunction_BSA_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_BSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-25-1 Батурина Софья Алексеевна", "Сообщение");
        }
        private void buttonDone_AAI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BSA.BackColor = Color.Red;
        }

        private void buttonDone_AAI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BSA.BackColor = Color.Green;
        }

        private void buttonDone_AAI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BSA.BackColor = Color.Blue;
        }
    }
}
    


