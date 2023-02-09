using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ischuk.lab8
{
    internal class String
    {
        public static string TestString()
        {
            string test = "Варкалось. Хливкие шорьки Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.\r\nО бойся Бармаглота, сын! Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг.";
            return test;
        }
        public static string TestString1()

        {
            string test = "Быть может, вся Природа – мозаика цветов?\r\n";
            return test;
        }
        public static string TestString2()
        {
            string test1 = "Быть может, вся Природа – различность голос?";
            return test1;
        }

        public static string VowCon(string word)
        {
            int Count1 = 0;
            int Count2 = 0;
            string vowels = "АЕЁИОУЫЭЮЯаеёиоуыэюя";
            string consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩбвгджзйклмнпрстфхцчшщ";
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    Count1++;
                }
                else if (consonants.Contains(word[i]))
                {
                    Count2++;
                }

            }
            return ("Гласных: " +  Count1.ToString() + "\r\nСогласных: " + Count2.ToString());
        }
        public static string Acount(string word)
        {
            int Count1 = 0;
            int Count2 = 0;
            string a = "аА";
            for (int i = 0; i < word.Length; i++)
            {
                if (a.Contains(word[i]))
                {
                    Count1++;
                }
                else
                    Count2++;

            }
            return ("Знаков A(a): " + Count1);
        }
        public static string EqualString(string word, string word1)
        {
            int Count1 = 0;
            int length = 0;
            if (word.Length > word1.Length)
            {
                length = word1.Length;
            }
            else
            {
                length = word.Length;
            }
            for (int i = 0; i < length; i++)
            {
                if (word[i] == word1[i])
                {
                    Count1++;
                }
                else
                    i = word.Length;
            }
            return ("Знаков Совпадает: " + Count1);
        }
    }
}
