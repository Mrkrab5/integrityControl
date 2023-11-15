using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrityControl
{
    internal class CRC
    {
        public CRC()
        { 
        
        }

        static private string GetBinValue(int symbol)
        {
            string result = "", reverse = "";
            int k = symbol;

            while (result.Length < 8)
            {
                result += k % 2;
                k /= 2;
            }

            for (int i = result.Length - 1; i >= 0; i--)
                reverse += result[i];

            return reverse + ' ';
        }

        static public string Check(string massenge)
        {
            string tmpString = massenge.ToUpper().Replace(" ", ""), bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", 
                result = "", binValue = "";

            int[] arrayValue = new int[3] {bigReg.IndexOf(tmpString[0]),
                                           bigReg.IndexOf(tmpString[1]),
                                           bigReg.IndexOf(tmpString[2])};

            for (int i = 0; i < 3; i++)
                binValue += GetBinValue(arrayValue[i]);

            result = $"Строка исходного сообщения (первые 3 буквы фамилии): {binValue}\n" +
                $"Строка после работы алгоритма CRC: ";

            binValue += "00010011";

            result += binValue;

            return result;
        }
    }
}
