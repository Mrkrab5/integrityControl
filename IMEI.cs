using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integrityControl
{
    internal class IMEI
    {

        public IMEI() 
        {
            
        }

        static public string Check(string massenge)
        {
            string tmpString = massenge.ToUpper().Replace(" ", ""), bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ", 
                kod = "", result = "";
            
            int sumOst = 0, sumChet = 0;

            for(int i = 0; i < tmpString.Length; i++)
            {
                if (kod.Length < 13)
                    kod += bigReg.IndexOf(tmpString[i]);
                else
                {
                    if ($"{kod + bigReg.IndexOf(tmpString[i])}".Length == 14)
                        kod += bigReg.IndexOf(tmpString[i]);
                }
            }

            for (int i = 0; i < kod.Length; i += 2)
            {
                sumOst += Int32.Parse(Convert.ToString(kod[i])) * 2 % 9;
                sumChet += Int32.Parse(Convert.ToString(kod[i + 1]));
            }

            result = $"{kod + ((sumChet + sumOst) % 10 == 0 ? 0 : 10 - (sumChet + sumOst) % 10)}";

            return result;
        }
    }
}
