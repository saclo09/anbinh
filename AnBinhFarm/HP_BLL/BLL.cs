using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP_BLL
{
    public class BLL
    {
        public static string mahoa(string s)
        {
           return CryptorEngine.Encrypt(s, true);
        }
        public static string giaima(string s)
        {
            return CryptorEngine.Decrypt(s, true);
        }

        public static string convertToUnSign2(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
           return (sb.ToString().Normalize(NormalizationForm.FormD));
        }

        public static string convertURL(string s)
        {

           string snew= convertToUnSign2(s);
           snew = snew.Replace("/", "-");
           snew = snew.Replace(" ", "-");
           snew = snew.Replace(".", "");
           snew = snew.Replace(",", "");
           snew = snew.Replace(":", "");
           snew = snew.Replace(";", "");
           snew = snew.Replace("!", "");
           snew = snew.Replace("?", "");
           snew = snew.Replace("[", "");
            snew = snew.Replace("]", "");
            snew = snew.Replace("{", "");
            snew = snew.Replace("}", "");
            snew = snew.Replace("$", "");
            snew = snew.Replace("%", "");
            snew = snew.Replace("^", "");

           return snew;
        }
   
    }
}
