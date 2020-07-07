using LatexDocGen.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexDocGen.Core
{
    public static class EnumExtensions
    {
        private static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return attributes.Length > 0
              ? (T)attributes[0]
              : null;
        }

        /// <summary>
        /// Gets the display name for the component type
        /// </summary>
        public static string GetName(this BlockType value)
        {
            var attribute = value.GetAttribute<TypeDefinition>();
            return attribute == null ? value.ToString() : attribute.Name;
        }

        /// <summary>
        /// Gets the class for the Parameter type
        /// </summary>
        public static Type GetClass(this ParameterType value)
        {
            var attribute = value.GetAttribute<ParameterTypeDefinition>();
            return attribute.Class;
        }
    }
}