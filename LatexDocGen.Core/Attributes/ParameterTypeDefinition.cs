using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core.Attributes
{
    internal class ParameterTypeDefinition : Attribute
    {
        public Type Class { get; internal set; }

        public ParameterTypeDefinition(Type @class)
        {
            Class = @class;
        }
    }
}