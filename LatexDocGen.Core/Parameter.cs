using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core
{
    public class Parameter
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual bool IsOptional => MinimumValues == 0;
        public virtual bool IsMultiple => MaximumValues > MinimumValues || MaximumValues == 0;
        public int MinimumValues { get; set; }
        public int MaximumValues { get; set; }
        public string[] Values { get; set; }

        public ParameterType Type { get; set; }

        public ChildBlock ChildBlock { get; set; }
    }
}