using LatexDocGen.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core
{
    public enum BlockType
    {
        [TypeDefinition("Configurations, Definitions & Imports")]
        Configuration,

        [TypeDefinition("Document Structure & General Use")]
        Structure,

        [TypeDefinition("Lists, Tables & Figures")]
        Lists,

        [TypeDefinition("Images & Graphics")]
        Graphics,

        [TypeDefinition("Code Highlighting")]
        Code,

        [TypeDefinition("Mathematics")]
        Math,

        [TypeDefinition("Hidden/Children")]
        Hidden
    }
}