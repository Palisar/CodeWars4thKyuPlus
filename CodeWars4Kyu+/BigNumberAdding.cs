using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4Kyu_
{
    public static class BigNumberAdding
    {
        public static string Add(string a, string b)
        {
            var A = BigInteger.Parse(a);
            var B = BigInteger.Parse(b);
            return (A + B).ToString();
        }

    }
}
