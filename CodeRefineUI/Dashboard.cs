using CodeRefineLibrary;
using System.Data;

namespace CodeRefineUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void processFiles_Click(object sender, EventArgs e)
        {
            if (!IsModelValid())
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateStatus("In progress");
            await FileProcessor.FindPatternAndProcess(selectedLocation.Text, fileTypeOptions.Text, 
                conditionOptions.Text, patternOptions.Text);
            UpdateStatus("Done");
        }

        private bool IsModelValid()
        {
            if (string.IsNullOrEmpty(selectedLocation.Text) || 
                fileTypeOptions.SelectedIndex == -1 ||
                conditionOptions.SelectedIndex == -1 ||
                patternOptions.SelectedIndex == -1
               )
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

        private void UpdateStatus(string message)
        {
            toolStripStatusLabel.Text = message;
        }
    }
}
