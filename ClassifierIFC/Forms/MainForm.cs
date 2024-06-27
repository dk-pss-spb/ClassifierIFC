using ClassifierIFC.Forms;
using ClassifierIFC.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml.Linq;
using Xbim.Ifc;
using Xbim.Ifc4.Interfaces;

namespace ClassifierIFC
{
    public partial class MainForm : Form
    {
        private string IFC_path;
        private string settings_path;
        private List<string> IFC_classes_list = new List<string>();//{"IfcWall", "IfcDoor" };
        public MainForm()
        {
            InitializeComponent();
        }

        public void Set_IFC_path(string path)
        {
            if (File.Exists(path))
            {
                this.IFC_path = path;
                this.label_IFCfile.Text = Path.GetFileName(this.IFC_path);
            }
            else            
                this.label_IFCfile.Text = "Не выбран";
            
        }
        public void Set_settings_path(string path)
        {
            if (File.Exists(path))
            {
                this.settings_path = path;
                this.labelsettingsFile.Text = Path.GetFileName(this.settings_path);
            }
            else
                this.labelsettingsFile.Text = "Не выбран";
        }

        private void aboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.IFC_path))
            {
                MessageBox.Show("Не выбран файл IFC.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.settings_path))
            {
                MessageBox.Show("Не выбран файл настроек.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            ProgressBarForm workingWindow = new ProgressBarForm(this.IFC_path, this.settings_path);
            workingWindow.ShowDialog();//.Show();
        }

      

        private void selectIFCpath_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_IFC_path(OpenFile(".ifc"));
        }
        private void selectSettingsPath_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_settings_path(OpenFile(".json"));
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
