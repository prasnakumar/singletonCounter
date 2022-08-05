using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
    


        public static string checkvalue(this int value)
        {
     return string.Concat('$', value);

        }
    }
}
