using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtentionMethods
{
    public static class CharType
    {
        public static string Check(this string text)
        {
            if (Regex.IsMatch(text, @"^[a-zA-Z]"))
                return "Letters";

            if (Regex.IsMatch(text, @"^[0-9]"))
                return "Digits";

            if (Regex.IsMatch(text, @"^[\-\.\,\!\?\;\:]"))
                return "Punctuation";

            if (Regex.IsMatch(text, @"^[\+\-\*\/\%\>\<\=]"))
                return "Arithmetic";

            return "Nothing";
        }
    }
}
