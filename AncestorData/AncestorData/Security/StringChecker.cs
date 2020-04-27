using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AncestorData.Security
{
    public class StringChecker
    {
        public static bool CheckIfStringIsSafe(string s)
        {
            if (s.Contains('.'))
                return false;
            if (s.Contains('%'))
                return false;
            if (s.Contains('/'))
                return false;
            if (s.Contains('\\'))
                return false;
            return true;
        }
    }
}
