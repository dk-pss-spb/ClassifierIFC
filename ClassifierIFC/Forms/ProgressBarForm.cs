using ClassifierIFC.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Xbim.Ifc;

namespace ClassifierIFC.Forms
{
    public partial class ProgressBarForm : Form
    {
        private string IFC_filePath;
        private Classifier_JSON classifier;
        private int indexStatus = 1;


        ToolStripLabel infoLabel;
        IProgress<int> progress;
        IProgress<string> status;

        public ProgressBarForm(string ifc_file_path, string classifier_filePath)
        {
            InitializeComponent();

            this.Text = "Анализ IFC";

            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Value = indexStatus;
            progressBar1.Step = 1;

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "0 %. Инициализация";
            statusStrip1.Items.Add(infoLabel);

            IFC_filePath = ifc_file_path;
            classifier = Classifier_JSON.ReadFromFile(classifier_filePath);

            progress = new Progress<int>((i) =>
            {
                this.progressBar1.Value = i;
            });

            status = new Progress<string>((s) =>
            {
                this.infoLabel.Text = s;
            });
        }

        public string GetStatus()
        {
            var persent = Math.Round((double)((double)progressBar1.Value / (double)progressBar1.Maximum * 100), 1);
            return 
            //infoLabel.Text = 
            $": {persent} %.   " +
                $"\tОбработано {progressBar1.Value} из {progressBar1.Maximum}";
        }

        public Task SearchObjects(Xbim.Common.IEntityCollection instances)//(string filePath)
        {
            return Task.Run(() =>
            {
                try
                {
                    string csv_fileName = Path.Combine(Path.GetDirectoryName(IFC_filePath),
                        Path.GetFileNameWithoutExtension(IFC_filePath) +    //$"Классификатор_" +
                        $" {DateTime.Now:yyyy-MM-dd-hh-mm-ss}" 
                        + ".csv");

                    this.Text += $": файл {csv_fileName}";

                    using (StreamWriter w = new StreamWriter(csv_fileName))//, false, Encoding.GetEncoding(1251)))
                    {
                        TextWriter oldOut = Console.Out;
                        Console.SetOut(w);

                        Console.WriteLine($"Наименование элемента\t" +
                            $"Класс\t" +
                            $"Тип\t" +
                            $"Код");

                        instances
                        //.Where(x =>
                        //        //(x is Xbim.Ifc2x3.Kernel.IfcObject) && 
                        //        (x as Xbim.Ifc2x3.Kernel.IfcObject)?.GetPropertySingleNominalValue("Другая", "Категория") != null
                        //        )
                        .AsParallel()
                        .Select(element => new OutClassifer(element, classifier))
                        .ForAll(                        
                        Work
                        );
                        status.Report(GetStatus());

                        Console.SetOut(oldOut);

                        MessageBox.Show($"Анализ IFC завершен!\nРезультат анализа записан в файл:\n{csv_fileName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            });
        }

        public void Work(OutClassifer outClassifer)
        {
            if (outClassifer.IsValid())
                Console.WriteLine(outClassifer.ToString());
            progress.Report(++indexStatus);
            status.Report(GetStatus());
        }


        private async  void ProgressBarForm_Shown(object sender, EventArgs e)
        {           

            string ifcFullName = IFC_filePath;
            using (var model = IfcStore.Open(ifcFullName))
            {
                var instances = model.Instances;
                progressBar1.Maximum = (int)instances.Count + 1;

                await SearchObjects(instances);
                this.DialogResult = DialogResult.OK;
                this.Close(); // Закрываем текущую форму
            }
        }

      

    }
}
