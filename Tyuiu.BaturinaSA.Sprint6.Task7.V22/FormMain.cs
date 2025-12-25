using System.Windows.Forms;
using Tyuiu.BaturinaSA.Sprint6.Task7.V22.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task7.V22
{
    public partial class FormMainTask_BSA : Form
    {
        public FormMainTask_BSA()
        {
            InitializeComponent();
            openFileDialogTask_BSA.Filter = "CSV|*.csv";
        }
        DataService ds = new DataService();
        private void buttonDone_BSA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOut_BSA.Rows.Clear();
                int[,] mtrx = ds.GetMatrix(openFileDialogTask_BSA.FileName);
                int rows = mtrx.GetUpperBound(0) + 1;
                int columns = mtrx.Length / rows;

                dataGridViewOut_BSA.ColumnCount = columns;
                dataGridViewOut_BSA.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOut_BSA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                    }
                }

                buttonSaveFileDialoge_BSA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewOut_BSA.Rows.Clear();
                buttonSaveFileDialoge_BSA.Enabled = false;

            }

        }


        private void buttonOpenFileDialoge_BSA_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogTask_BSA.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialogTask_BSA.FileName))
                    {
                        dataGridViewIn_BSA.Rows.Clear();
                        dataGridViewIn_BSA.Columns.Clear();
                        string line;
                        while ((line = reader.ReadLine()) != null && line != "")
                        {
                            if (dataGridViewIn_BSA.Columns.Count == 0)
                            {
                                dataGridViewIn_BSA.ColumnCount = line.Split(';').Length;
                            }
                            dataGridViewIn_BSA.Rows.Add(line.Split(';'));
                        }
                    }
                    buttonDone_BSA.Enabled = true;
                }
            }
            catch
            {
                dataGridViewIn_BSA.Columns.Clear();
                buttonDone_BSA.Enabled = buttonSaveFileDialoge_BSA.Enabled = false;
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void buttonSaveFileDialoge_BSA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_BSA.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_BSA.Filter = "CSV|*.csv";
            if (saveFileDialogTask_BSA.ShowDialog() == DialogResult.OK)
            {
                int rows = dataGridViewOut_BSA.RowCount;
                int columns = dataGridViewOut_BSA.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_BSA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_BSA.Rows[i].Cells[j].Value;
                        }
                    }
                    str += Environment.NewLine;
                }
                File.WriteAllText(saveFileDialogTask_BSA.FileName, str);
                MessageBox.Show("Файл успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonHelp_BSA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridViewIn_BSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOut_BSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenFileDialoge_BSA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BSA_DragEnter(object sender, DragEventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFileDialoge_BSA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_BSA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void toolTipTask_BSA_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
