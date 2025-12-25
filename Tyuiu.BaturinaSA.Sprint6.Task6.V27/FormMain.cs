using Tyuiu.BaturinaSA.Sprint6.Task6.V27.Lib;
namespace Tyuiu.BaturinaSA.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void textBoxConclusion_BSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_BSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_BSA_Click(object sender, EventArgs e)
        {
            textBoxConclusion_BSA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFiled_BSA_Click(object sender, EventArgs e)
        {
            openFileDialog_BSA.ShowDialog();
            openFilePath = openFileDialog_BSA.FileName;
            textBoxInput_BSA.Text = File.ReadAllText(openFilePath);
            groupBoxInput_BSA.Text = groupBoxInput_BSA.Text + " " + openFileDialog_BSA.FileName;
            buttonDone_BSA.Enabled = true;
        }

        private void buttonHelp_BSA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void openFileDialog_BSA_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
