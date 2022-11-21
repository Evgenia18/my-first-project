using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factionfile;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            flot fuct=new flot();
            fuct.HelloWord("Евгения");
            Console.WriteLine($"Через 10 лет вам будет - {fuct.AgeToTen(30)}");
            Console.ReadLine();
        }


    }

}