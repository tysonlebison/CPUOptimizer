using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace CPUOptimizer
{
    class Optimizer
    {
        public void setProcessAffinity(string processName ,int affinityLevel)
        {
            Process[] theProcesses = Process.GetProcessesByName(processName);
            foreach (Process thisProcess in theProcesses)
            {
                foreach (ProcessThread processThread in thisProcess.Threads)
                {
                    processThread.ProcessorAffinity = (IntPtr)affinityLevel;
                }
            }
        }
    }
}
