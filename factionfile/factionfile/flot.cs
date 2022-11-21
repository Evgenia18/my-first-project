using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factionfile
{
    public class flot
    {
        public void HelloWord(string name)
        {

            Console.WriteLine($"Привет,{name}"); 
        }

        public int AgeToTen (int age)
        {
            return age + 10;
        }

        public dynamic AnsParse(byte[] Array)
        {
            switch (Array[0])
            {
                case 1:
                    return 1; // возвращаем число
                case 2:
                    return false; // возвращаем булевое значение
            }
            return "no result"; // возвращаем строку
        }


        public string Reverse(string s)
        {
            string s2 = "";
            int len = s.Length;

            for (int i = 0; i < len; i++)
                s2 += s[len - i - 1];

            return s2;
        }
    }
}
