using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = { "", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
            string[] million = { "", " mươi", " trăm", "" };
            string[] billion = { "", "", "", " nghìn", "", "", " triệu", "", "" };
            string result = "{0}";
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                if (count > 0 && count % 9 == 0)
                    result = string.Format(result, "{0} tỷ");
                if (!(count < string.Length - 3 && count > 2 && string[i].Equals('0') && string[i - 1].Equals('0') && string[i - 2].Equals('0')))
                    result = string.Format(result, "{0}" + billion[count % 9]);
                if (!string[i].Equals('0'))
                    result = string.Format(result, "{0}" + million[count % 3]);
                else if (count % 3 == 1 && count > 1 && !string[i - 1].Equals('0') && !string[i + 1].Equals('0'))
                    result = string.Format(result, "{0} lẻ");
                var num = Convert.ToInt16(string[i].ToString());
                result = string.Format(result, "{0}" + word[num]);
                count++;
            }
            result = result.Replace("{0}", ""); 
  
            Console.ReadKey();
        }
    }
}
