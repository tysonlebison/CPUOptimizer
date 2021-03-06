﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CPUOptimizer
{
    public partial class FormCPUOptimizer : Form
    {
        public double affinityLevel;
        public FormCPUOptimizer()
        {
            InitializeComponent();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                cboxCores.Items.Add("Core " + i.ToString());
            }
        }

        private void saveCurrentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cboxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCurrentProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCurrentProcesses_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestoreDefault_Click(object sender, EventArgs e)
        {

        }

        private void cboxCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cboxCores.Items.Count; i++)
            {
                if (cboxProcesses.GetItemChecked(i) == true)
                {
                    affinityLevel += Math.Pow(double.Parse(2.ToString()), double.Parse(5.ToString()));
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void listBoxDefaultCore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadProfileTStrip_Click(object sender, EventArgs e)
        {

        }

        private void autoProfileTstrip_Click(object sender, EventArgs e)
        {

        }

        private void aboutTstrip_Click(object sender, EventArgs e)
        {

        }

        private void exitTstrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProcesses_Click(object sender, EventArgs e)
        {
            cboxProcesses.Items.Clear();
            Process[] currentProcesses = Process.GetProcesses();
            foreach (Process theProcess in currentProcesses)
            {
                cboxProcesses.Items.Add(theProcess.ProcessName);
            }
        }
    }
}
