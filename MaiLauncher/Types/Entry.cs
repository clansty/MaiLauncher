using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace MaiLauncher.Types
{
    internal class Entry
    {
        public string Name { get; set; }
        public List<Command> Commands { get; set; } = [];
        public char Key { get; set; }
        public string KeyDisplay { get; set; }
        public bool Exit { get; set; }
    }
}
