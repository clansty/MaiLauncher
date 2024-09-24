using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiLauncher.Types
{
    internal class Command
    {
        public string Exec { get; set; }
        public string WorkDir { get; set; }
        public bool Hidden { get; set; }
    }
}
