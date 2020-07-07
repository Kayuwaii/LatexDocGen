using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core
{
    public class ChildBlock
    {
        public string Block { get; set; }

        public int[] ParentParams { get; set; }
    }
}