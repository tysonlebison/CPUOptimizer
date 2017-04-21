namespace CPUOptimizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.profilingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileTStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeProfileTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProcesses = new System.Windows.Forms.Label();
            this.cboxProcesses = new System.Windows.Forms.CheckedListBox();
            this.cboxCores = new System.Windows.Forms.CheckedListBox();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.autoProfileTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTstrip,
            this.profilingToolStripMenuItem,
            this.aboutTstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileTstrip
            // 
            this.fileTstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTstrip});
            this.fileTstrip.Name = "fileTstrip";
            this.fileTstrip.Size = new System.Drawing.Size(37, 20);
            this.fileTstrip.Text = "File";
            // 
            // profilingToolStripMenuItem
            // 
            this.profilingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileTStrip,
            this.saveCurrentProfileToolStripMenuItem,
            this.makeProfileTstrip,
            this.autoProfileTstrip});
            this.profilingToolStripMenuItem.Name = "profilingToolStripMenuItem";
            this.profilingToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.profilingToolStripMenuItem.Text = "Profiling";
            // 
            // loadProfileTStrip
            // 
            this.loadProfileTStrip.Name = "loadProfileTStrip";
            this.loadProfileTStrip.Size = new System.Drawing.Size(178, 22);
            this.loadProfileTStrip.Text = "Load Profile";
            // 
            // saveCurrentProfileToolStripMenuItem
            // 
            this.saveCurrentProfileToolStripMenuItem.Name = "saveCurrentProfileToolStripMenuItem";
            this.saveCurrentProfileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveCurrentProfileToolStripMenuItem.Text = "Save Current Profile";
            this.saveCurrentProfileToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentProfileToolStripMenuItem_Click);
            // 
            // makeProfileTstrip
            // 
            this.makeProfileTstrip.Name = "makeProfileTstrip";
            this.makeProfileTstrip.Size = new System.Drawing.Size(178, 22);
            this.makeProfileTstrip.Text = "Make Profile";
            // 
            // exitTstrip
            // 
            this.exitTstrip.Name = "exitTstrip";
            this.exitTstrip.Size = new System.Drawing.Size(152, 22);
            this.exitTstrip.Text = "Exit";
            this.exitTstrip.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutTstrip
            // 
            this.aboutTstrip.Name = "aboutTstrip";
            this.aboutTstrip.Size = new System.Drawing.Size(52, 20);
            this.aboutTstrip.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblCores);
            this.panel1.Controls.Add(this.cboxCores);
            this.panel1.Controls.Add(this.cboxProcesses);
            this.panel1.Controls.Add(this.lblProcesses);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 530);
            this.panel1.TabIndex = 1;
            // 
            // lblProcesses
            // 
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Location = new System.Drawing.Point(3, 17);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(83, 20);
            this.lblProcesses.TabIndex = 0;
            this.lblProcesses.Text = "Processes";
            // 
            // cboxProcesses
            // 
            this.cboxProcesses.FormattingEnabled = true;
            this.cboxProcesses.Location = new System.Drawing.Point(3, 40);
            this.cboxProcesses.Name = "cboxProcesses";
            this.cboxProcesses.Size = new System.Drawing.Size(277, 487);
            this.cboxProcesses.TabIndex = 1;
            // 
            // cboxCores
            // 
            this.cboxCores.FormattingEnabled = true;
            this.cboxCores.Location = new System.Drawing.Point(739, 40);
            this.cboxCores.Name = "cboxCores";
            this.cboxCores.Size = new System.Drawing.Size(153, 172);
            this.cboxCores.TabIndex = 2;
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(735, 17);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(51, 20);
            this.lblCores.TabIndex = 3;
            this.lblCores.Text = "Cores";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(439, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "asdf";
            // 
            // autoProfileTstrip
            // 
            this.autoProfileTstrip.Name = "autoProfileTstrip";
            this.autoProfileTstrip.Size = new System.Drawing.Size(178, 22);
            this.autoProfileTstrip.Text = "Automatic Profiling";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CPU Optimizer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTstrip;
        private System.Windows.Forms.ToolStripMenuItem profilingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfileTStrip;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeProfileTstrip;
        private System.Windows.Forms.ToolStripMenuItem exitTstrip;
        private System.Windows.Forms.ToolStripMenuItem aboutTstrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem autoProfileTstrip;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.CheckedListBox cboxCores;
        private System.Windows.Forms.CheckedListBox cboxProcesses;
        private System.Windows.Forms.Label lblProcesses;
    }
}

