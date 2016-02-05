using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNK.Common.Utilities
{
    public class Helpers
    {
        public static string GetShortName(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            str = str.Trim();
            var listWord = str.Split(' ');
            string result = listWord.Aggregate(string.Empty, (current, item) => current + item.Substring(0, 1));
            return result;
        }
    }
}
