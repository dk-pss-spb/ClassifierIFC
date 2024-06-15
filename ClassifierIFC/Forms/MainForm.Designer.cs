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
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
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
            this.menuStrip2.Size = new System.Drawing.Size(482, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // file_ToolStripMenuItem
            // 
            this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            this.file_ToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.file_ToolStripMenuItem.Text = "Файл";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 242);
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
    }
}

