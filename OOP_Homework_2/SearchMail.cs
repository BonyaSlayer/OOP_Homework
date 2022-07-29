using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    public class SearchMail
    {
        /// <summary>
        /// Метод поиска мыла
        /// </summary>
        /// <param name="a">Строка из файла</param>
        /// <returns></returns>
        public string SearchTheMail(ref string a)
        {
            string[] email = a.Split(new char[] { '&' });
            return email[1];

        }
    }
}
