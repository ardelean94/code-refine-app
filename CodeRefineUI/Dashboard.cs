using CodeRefineLibrary;

namespace CodeRefineUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void processFiles_Click(object sender, EventArgs e)
        {
            if (!IsModelValid())
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileProcessor.FindPatternAndProcess(selectedLocation.Text, regexPatternText.Text);
        }

        private bool IsModelValid()
        {
            if (string.IsNullOrEmpty(selectedLocation.Text) || string.IsNullOrEmpty(regexPatternText.Text))
                return false;

            return true;
        }

        private void browseFiles_Click(object sender, EventArgs e)
        {
            if(browseFolder.ShowDialog() == DialogResult.OK)
            {
                selectedLocation.Text = browseFolder.SelectedPath;
            }
        }
    }
}
