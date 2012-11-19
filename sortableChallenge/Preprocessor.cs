using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace sortableChallenge
{
    class Preprocessor
    {
        public static string pre_process(string inp)
        {
            inp = inp.Replace("-", " ");
            inp = inp.Replace("_", " ");
            inp = Regex.Replace(inp, @"\s+", " ");

            return inp.ToLower().Trim();
        }
    }
}
