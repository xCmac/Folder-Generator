using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Diagnostics;

namespace TriliumFolderGenerator
{
    public partial class Form1 : Form
    {
        string jobName;
        ConfigurationModel configuration;
        string jobType = @"DPS-";

        public Form1()
        {
            InitializeComponent();
            loadConfiguration();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void loadConfiguration()
        {
            configuration = JsonConvert.DeserializeObject<ConfigurationModel>(File.ReadAllText(@"config.json"));
            foldersListBox.Items.Clear();

            if(jobType == "DPS-")
            {
                foreach (string folder in configuration.FoldersDPS)
                {
                    foldersListBox.Items.Add(folder);
                }
            }

            if(jobType == "DPO-")
            {
                foreach (string folder in configuration.FoldersDPO)
                {
                    foldersListBox.Items.Add(folder);
                }
            }


            textbox_documents_directory.Text = configuration.JobDocumentsDirectory;
            textbox_creation_directory.Text = configuration.CreationDirectory;
        }

        private string getFolderPath()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderDlg.SelectedPath;
            }

            return "";
        }

        private void updateConfigurationFile()
        {
            File.WriteAllText(@"config.json", JsonConvert.SerializeObject(configuration));
            loadConfiguration();
        }

        private void createFolders()
        {
            if (Directory.Exists(getOutputDirectory()))
            {
                MessageBox.Show("Directory already exists", "Directory Exists");
                return;
            }

            DirectoryInfo di = Directory.CreateDirectory(getOutputDirectory());

            if(jobType == "DPS-")
            {
                foreach (string folder in configuration.FoldersDPS)
                {
                    Directory.CreateDirectory($"{getOutputDirectory()}\\{folder}");
                }
            }

            if (jobType == "DPO-")
            {
                foreach (string folder in configuration.FoldersDPO)
                {
                    Directory.CreateDirectory($"{getOutputDirectory()}\\{folder}");
                }
            }
        }

        private void copyDocuments()
        {
            string[] fileList = Directory.GetFiles(configuration.JobDocumentsDirectory);
            foreach (string f in fileList)
            {
                string fName = f.Substring(configuration.JobDocumentsDirectory.Length + 1);
                File.Copy(Path.Combine(configuration.JobDocumentsDirectory, fName), Path.Combine(configuration.CreationDirectory, jobName, fName), true);
            }
        }

        #region events
        private void button_generate_Click(object sender, EventArgs e)
        {
            createFolders();
            if(!string.IsNullOrEmpty(textbox_documents_directory.Text)) {
                copyDocuments();
            }

            if(checkbox_openAfter.Checked) Process.Start(getOutputDirectory());
            textbox_job.Clear();
        }

        private string getOutputDirectory()
        {
            string rootDirectory = string.IsNullOrEmpty(configuration.CreationDirectory) ? Directory.GetCurrentDirectory() : configuration.CreationDirectory;
            string rootWithNewJobPath = $"{rootDirectory}\\{jobName}";

            return rootWithNewJobPath;
        }

        private void textbox_job_TextChanged(object sender, EventArgs e)
        {

            if (!textbox_job.Text.StartsWith(jobType))
            {
                textbox_job.Text = jobType;
                textbox_job.SelectionStart = textbox_job.Text.Length;
            }

            jobName = textbox_job.Text;
            button_generate.Enabled = !string.IsNullOrWhiteSpace(textbox_job.Text) && textbox_job.Text.Length > 4;
        }

        private void job_type_radio_changed(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                jobType = rb.Text;
                textbox_job.Text = rb.Text;
                loadConfiguration();
            }
        }

        private void textbox_job_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && key != 8) //8 is backspace
            {
                e.Handled = true;
            }
        }

        private void textbox_job_Enter(object sender, EventArgs e)
        {
            textbox_job.SelectionStart = textbox_job.Text.Length;
        }

        private void button_select_documents_directory_Click(object sender, EventArgs e)
        {
            textbox_documents_directory.Text = getFolderPath();
            configuration.JobDocumentsDirectory = textbox_documents_directory.Text;
            updateConfigurationFile();
        }

        private void button_select_creation_directory_Click(object sender, EventArgs e)
        {
            textbox_creation_directory.Text = getFolderPath();
            configuration.CreationDirectory = textbox_creation_directory.Text;
            updateConfigurationFile();
        }

        private void button_delete_folder_Click(object sender, EventArgs e)
        {
            string selectedItem = foldersListBox.SelectedItem.ToString();
            foldersListBox.Items.Remove(selectedItem);

            if(jobType == "DPS-")
            {
                configuration.FoldersDPS.Remove(selectedItem);
            }

            if (jobType == "DPO-")
            {
                configuration.FoldersDPO.Remove(selectedItem);
            }

            updateConfigurationFile();
        }

        private void textbox_new_folder_name_TextChanged(object sender, EventArgs e)
        {
            const string prefix = @"/";
            if(!textbox_new_folder_name.Text.StartsWith(prefix))
            {
                textbox_new_folder_name.Text = prefix;
                textbox_new_folder_name.SelectionStart = textbox_new_folder_name.Text.Length;
            }

            button_add_new_folder.Enabled = textbox_new_folder_name.Text.Length > 1;
        }

        private void textbox_add_new_folder_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsLetterOrDigit(key) && 
                key != '/' &&
                !char.IsWhiteSpace(key) &&
                key != 8) // 8 is backspace
            {
                e.Handled = true;
            }
        }

        private void button_add_new_folder_Click(object sender, EventArgs e)
        {
            string newFolder = textbox_new_folder_name.Text.Trim().TrimEnd('/');

            if (jobType == "DPS-")
            {
                configuration.FoldersDPS.Add(newFolder);
            }
            if (jobType == "DPO-")
            {
                configuration.FoldersDPO.Add(newFolder);
            }

            updateConfigurationFile();
            textbox_new_folder_name.Clear();
        }

        private void foldersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_delete_folder.Enabled = true;
        }
        #endregion
    }
}
