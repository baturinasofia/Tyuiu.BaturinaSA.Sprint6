using Tyuiu.BaturinaSA.Sprint6.Task3.V24.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void buttonReference_BSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-25-1 Батурина Софья Алексеевна", "Сообщение");
        }

        private void buttonDone_BSA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { -17, -6, 10, -7, -3 }, { -10, -14, 10, -7, -3 }, { -19, 9, 8, -17, -9 }, { -19, -5, -9, -18, 14 }, { 17, 12, 11, 12, 2 } };
            int[,] res = ds.Calculate(mtrx);

            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewResult_BSA.ColumnCount = cols;
            dataGridViewResult_BSA.RowCount = rows;


            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult_BSA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_BSA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void dataGridViewResult_BSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxResult_BSA_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxResult_BSA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
