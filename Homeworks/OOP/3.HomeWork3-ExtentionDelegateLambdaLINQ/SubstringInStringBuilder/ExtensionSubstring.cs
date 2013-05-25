using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInStringBuilder
{
    static class ExtensionSubstring
    {
        // Extending class StringBuilder with method substring
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            StringBuilder newStringBuilder = new StringBuilder();
            string str = builder.ToString();
            string sub = str.Substring(index, length);
            return newStringBuilder.Append(sub);
        }
    }
}
