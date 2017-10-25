using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GuildWars2Helper.Utilities
{
    public class Application
    {
        public static void OpenApplication(string EXEPath)
        {
            Process.Start(EXEPath);
        }
    }
}
