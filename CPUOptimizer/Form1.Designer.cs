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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profilingTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfileTStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentToProfileTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProcesses = new System.Windows.Forms.Label();
            this.cboxProcesses = new System.Windows.Forms.CheckedListBox();
            this.cboxCores = new System.Windows.Forms.CheckedListBox();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblCurrentProcesses = new System.Windows.Forms.Label();
            this.autoProfileTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxCurrentProcesses = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDefaultCore = new System.Windows.Forms.Label();
            this.btnRestoreDefault = new System.Windows.Forms.Button();
            this.exitTstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilingTstrip,
            this.aboutTstrip,
            this.exitTstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profilingTstrip
            // 
            this.profilingTstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileTStrip,
            this.saveCurrentToProfileTstrip,
            this.autoProfileTstrip});
            this.profilingTstrip.Name = "profilingTstrip";
            this.profilingTstrip.Size = new System.Drawing.Size(64, 20);
            this.profilingTstrip.Text = "Profiling";
            // 
            // loadProfileTStrip
            // 
            this.loadProfileTStrip.Name = "loadProfileTStrip";
            this.loadProfileTStrip.Size = new System.Drawing.Size(194, 22);
            this.loadProfileTStrip.Text = "Load Profile";
            // 
            // saveCurrentToProfileTstrip
            // 
            this.saveCurrentToProfileTstrip.Name = "saveCurrentToProfileTstrip";
            this.saveCurrentToProfileTstrip.Size = new System.Drawing.Size(194, 22);
            this.saveCurrentToProfileTstrip.Text = "Save Current To Profile";
            this.saveCurrentToProfileTstrip.Click += new System.EventHandler(this.saveCurrentProfileToolStripMenuItem_Click);
            // 
            // aboutTstrip
            // 
            this.aboutTstrip.Name = "aboutTstrip";
            this.aboutTstrip.Size = new System.Drawing.Size(52, 20);
            this.aboutTstrip.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRestoreDefault);
            this.panel1.Controls.Add(this.lblDefaultCore);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.listBoxCurrentProcesses);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblCurrentProcesses);
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
            // lblCurrentProcesses
            // 
            this.lblCurrentProcesses.AutoSize = true;
            this.lblCurrentProcesses.Location = new System.Drawing.Point(337, 17);
            this.lblCurrentProcesses.Name = "lblCurrentProcesses";
            this.lblCurrentProcesses.Size = new System.Drawing.Size(207, 20);
            this.lblCurrentProcesses.TabIndex = 4;
            this.lblCurrentProcesses.Text = "Current Processes Selected";
            // 
            // autoProfileTstrip
            // 
            this.autoProfileTstrip.Name = "autoProfileTstrip";
            this.autoProfileTstrip.Size = new System.Drawing.Size(194, 22);
            this.autoProfileTstrip.Text = "Automatic Profiling";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxCurrentProcesses
            // 
            this.listBoxCurrentProcesses.FormattingEnabled = true;
            this.listBoxCurrentProcesses.ItemHeight = 20;
            this.listBoxCurrentProcesses.Location = new System.Drawing.Point(341, 40);
            this.listBoxCurrentProcesses.Name = "listBoxCurrentProcesses";
            this.listBoxCurrentProcesses.Size = new System.Drawing.Size(203, 484);
            this.listBoxCurrentProcesses.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(739, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 224);
            this.listBox1.TabIndex = 7;
            // 
            // lblDefaultCore
            // 
            this.lblDefaultCore.AutoSize = true;
            this.lblDefaultCore.Location = new System.Drawing.Point(735, 280);
            this.lblDefaultCore.Name = "lblDefaultCore";
            this.lblDefaultCore.Size = new System.Drawing.Size(99, 20);
            this.lblDefaultCore.TabIndex = 8;
            this.lblDefaultCore.Text = "Default Core";
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.Location = new System.Drawing.Point(550, 452);
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.Size = new System.Drawing.Size(183, 72);
            this.btnRestoreDefault.TabIndex = 9;
            this.btnRestoreDefault.Text = "Restore Windows Default";
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            // 
            // exitTstrip
            // 
            this.exitTstrip.Name = "exitTstrip";
            this.exitTstrip.Size = new System.Drawing.Size(37, 20);
            this.exitTstrip.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Process Info";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(554, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(179, 185);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
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
        private System.Windows.Forms.ToolStripMenuItem profilingTstrip;
        private System.Windows.Forms.ToolStripMenuItem loadProfileTStrip;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentToProfileTstrip;
        private System.Windows.Forms.ToolStripMenuItem aboutTstrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem autoProfileTstrip;
        private System.Windows.Forms.Label lblCurrentProcesses;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.CheckedListBox cboxCores;
        private System.Windows.Forms.CheckedListBox cboxProcesses;
        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxCurrentProcesses;
        private System.Windows.Forms.ToolStripMenuItem exitTstrip;
        private System.Windows.Forms.Button btnRestoreDefault;
        private System.Windows.Forms.Label lblDefaultCore;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

