using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    public class ReverseString
    {
        /// <summary>
        /// Метод переворота строки
        /// </summary>
        /// <param name="word">слово</param>
        /// <returns></returns>
        public static string ReverseWord(ref string word)
        {
            char[] chars = word.ToCharArray();
            string result = string.Empty;
            StringBuilder builder = new StringBuilder();
            for(int i = chars.Length - 1; i >= 0; i--)
            {
                result = builder.Append(chars[i]).ToString();
            }
            return result;
        }

    }
}
