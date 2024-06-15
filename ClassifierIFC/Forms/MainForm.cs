using ClassifierIFC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassifierIFC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProgramForm = new AboutProgramForm();
            aboutProgramForm.ShowDialog();
        }
    }
}
