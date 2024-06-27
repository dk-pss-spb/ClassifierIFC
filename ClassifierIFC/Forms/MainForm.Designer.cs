namespace ClassifierIFC
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectIFCpath_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSettingsPath_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_IFCfile = new System.Windows.Forms.Label();
            this.labelsettingsFile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem,
            this.help_ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(749, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // file_ToolStripMenuItem
            // 
            this.file_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectIFCpath_ToolStripMenuItem,
            this.selectSettingsPath_ToolStripMenuItem});
            this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            this.file_ToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.file_ToolStripMenuItem.Text = "Файл";
            // 
            // selectIFCpath_ToolStripMenuItem
            // 
            this.selectIFCpath_ToolStripMenuItem.Name = "selectIFCpath_ToolStripMenuItem";
            this.selectIFCpath_ToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.selectIFCpath_ToolStripMenuItem.Text = "Выбрать IFC-файл";
            this.selectIFCpath_ToolStripMenuItem.Click += new System.EventHandler(this.selectIFCpath_ToolStripMenuItem_Click);
            // 
            // selectSettingsPath_ToolStripMenuItem
            // 
            this.selectSettingsPath_ToolStripMenuItem.Name = "selectSettingsPath_ToolStripMenuItem";
            this.selectSettingsPath_ToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.selectSettingsPath_ToolStripMenuItem.Text = "Выбрать файл соответствия";
            this.selectSettingsPath_ToolStripMenuItem.Click += new System.EventHandler(this.selectSettingsPath_ToolStripMenuItem_Click);
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgram_ToolStripMenuItem});
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.help_ToolStripMenuItem.Text = "Помощь";
            // 
            // aboutProgram_ToolStripMenuItem
            // 
            this.aboutProgram_ToolStripMenuItem.Name = "aboutProgram_ToolStripMenuItem";
            this.aboutProgram_ToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.aboutProgram_ToolStripMenuItem.Text = "О программе";
            this.aboutProgram_ToolStripMenuItem.Click += new System.EventHandler(this.aboutProgram_ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IFC-файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Файл соответствия:";
            // 
            // label_IFCfile
            // 
            this.label_IFCfile.AutoSize = true;
            this.label_IFCfile.Location = new System.Drawing.Point(197, 61);
            this.label_IFCfile.Name = "label_IFCfile";
            this.label_IFCfile.Size = new System.Drawing.Size(90, 20);
            this.label_IFCfile.TabIndex = 4;
            this.label_IFCfile.Text = "Не выбран";
            // 
            // labelsettingsFile
            // 
            this.labelsettingsFile.AutoSize = true;
            this.labelsettingsFile.Location = new System.Drawing.Point(197, 105);
            this.labelsettingsFile.Name = "labelsettingsFile";
            this.labelsettingsFile.Size = new System.Drawing.Size(90, 20);
            this.labelsettingsFile.TabIndex = 5;
            this.labelsettingsFile.Text = "Не выбран";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Преобразование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelsettingsFile);
            this.Controls.Add(this.label_IFCfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassifierIFC";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectIFCpath_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSettingsPath_ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_IFCfile;
        private System.Windows.Forms.Label labelsettingsFile;
        private System.Windows.Forms.Button button1;
    }
}

