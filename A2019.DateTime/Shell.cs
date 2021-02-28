using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace A2019.Convertor
{
    public class Shell
    {
        public static void TestMethod()
        {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process proc = new Process { StartInfo = startInfo };
            proc.Start();
            proc.StandardInput.WriteLine(@" /s /b c:\*");
            proc.WaitForExit();

        }
        
    }
}
