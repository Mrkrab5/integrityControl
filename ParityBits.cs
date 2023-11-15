using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrityControl
{
    internal class ParityBits
    {

        public ParityBits()
        {

        }

        static private string GetBinValue(char symbol)
        {
            string result = "", reverse = "";
            int k = symbol;

            while(k > 0)
            {
                result += k % 2;
                k /= 2;
            }

            for(int i = result.Length - 1; i >= 0; i--)
                reverse += result[i];

            result = reverse;

            if ((result.Split('1').Length - 1) % 2 == 1)
                result += '1';
            else
                result += '0';

            return result + " ";
        }

        static public string Check(string massenge)
        {
            string tmpString = massenge.ToUpper(), result = "";

            foreach (char c in tmpString)
                result += GetBinValue(c);

            return result;
        }
    }
}
