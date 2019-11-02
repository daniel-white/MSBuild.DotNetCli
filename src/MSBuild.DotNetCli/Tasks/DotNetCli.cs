using System;
using System.Diagnostics;
using Microsoft.Build.Utilities;

namespace DanielWhite.MSBuild.DotNetCli.Tasks
{
    public class DotNetCli : Task
    {
        public override bool Execute()
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = WorkingDirectory ?? string.Empty,
                    FileName = "dotnet",
                    Arguments = $"{Tool} { Arguments ?? string.Empty }",
                    CreateNoWindow = true,
                };

                using Process process = Process.Start(processStartInfo);
                process.WaitForExit();
                return process.ExitCode == 0;
            }
            catch (Exception ex)
            {
                Log.LogErrorFromException(ex);
                return false;
            }
        }

        public string Tool { get; set; }

        public string Arguments { get; set; }

        public string WorkingDirectory { get; set; }
    }
}
