using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core
{
    public class Block
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public BlockType Type { get; set; }
        public string File { get; set; }

        public Parameter[] Parameters { get; set; }
    }
}