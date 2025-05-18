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

            FileProcessor.FindPatternAndProcess(selectedLocation.Text, regexPatternOptions.Text);
        }

        private bool IsModelValid()
        {
            if (string.IsNullOrEmpty(selectedLocation.Text) || regexPatternOptions.SelectedIndex == -1)
                return false;

            return true;
        }

        private void browseFiles_Click(object sender, EventArgs e)
        {
            if(browseFolderDialog.ShowDialog() == DialogResult.OK)
            {
                selectedLocation.Text = browseFolderDialog.SelectedPath;
            }
        }
    }
}
