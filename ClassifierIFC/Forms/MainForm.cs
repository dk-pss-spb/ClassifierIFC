using ClassifierIFC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassifierIFC
{
    public partial class MainForm : Form
    {
        private string IFC_path;
        private string settings_path;
        public MainForm()
        {
            InitializeComponent();
        }

        public void Set_IFC_path(string path)
        {
            if (File.Exists(path))
            {
                this.IFC_path = path;

            }
        }
        public void Set_settings_path(string path)
        {
            if (File.Exists(path))
            {
                this.settings_path = path;

            }
        }

        private void aboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.ShowDialog();
        }

        private void selectIFCpath_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_IFC_path(OpenFile(".ifc"));
        }
        private void selectSettingsPath_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_settings_path(OpenFile(".xml"));
        }

        public static string OpenFile(string extensionFile)
        {
            var filePath = string.Empty;
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                System.Windows.Forms.DialogResult dialog_result = new System.Windows.Forms.DialogResult();
                dialog_result = openFileDialog.ShowDialog();

                if (dialog_result == System.Windows.Forms.DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    if (Path.GetExtension(filePath).ToLower() != extensionFile.ToLower())
                    {
                        System.Windows.Forms.MessageBox.Show($"Выбранный файл не соответствует расширению '{extensionFile}'", "Ошибка.");
                        return null;
                    }
                }
                else return null;
            }
            return filePath;
        }

        
    }
}
