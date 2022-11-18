
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    // клас, реализующий комплексное число
    class Complex
    {
        // внутренние переменные
        private double real; // действительная часть
        private double imag; // мнимая часть


        public Complex()
        {
            real = imag = 0;
        }

        public Complex(double _real, double _imag)
        {
            real = _real;
            imag = _imag;
        }

        // методы доступа
        // получить значения переменных real, imag
        public void ZEC(out double _real, out double _imag)
        {
            _real = real;
            _imag = imag;
        }

        // установить новые значения real и imag
        public void OP(double _real, double _imag)
        {
            real = _real;
            imag = _imag;
        }

        // метод, возвращающий текущий экземпляр
        public Complex BNM()
        {
            return this;
        }

        // метод, возвращающий объект класса 
        public void BNM2(out Complex _cmp)
        {
            Complex cmp = new Complex(real, imag);
            _cmp = cmp; 
        }
    }

    class Program
    {
        // метод класса Program, возвращающий объект 
        public Complex BNM3(double _real, double _imag)
        {
            Complex comp = new Complex();
            comp.OP(_real, _imag);
            return comp;
        }

        static void Main(string[] args)
        {
            Complex c = new Complex(3, 5); // создать экземпляр класса
            double P, X;

            // возврат объекта с помощью метода 
            Complex c2;
            c2 = c.BNM();

            // проверка
            c2.ZEC(out P, out X);

            Console.WriteLine("Method BNM");
            Console.WriteLine("P = {0}", P);
            Console.WriteLine("X = {0}", X);

             
            Complex c3;

            c.BNM2(out c3);

            // проверка
            c3.ZEC(out P, out X);

            Console.WriteLine("Method BNM");
            Console.WriteLine("P = {0}", P);
            Console.WriteLine("X = {0}", X);

            Console.ReadKey();
        }
    }
}




