using System;
using Microsoft.Build.Tasks;

namespace MSBuild.DotNetCli.Tasks
{
    public class DotNetCli : ToolTaskExtension
    {
        protected override string ToolName => nameof(DotNetCli);

        protected override string GenerateFullPathToTool()
        {
            throw new NotImplementedException();
        }
    }
}
