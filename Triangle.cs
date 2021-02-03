using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Var4
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double Sq1;
        public static int count = 0;
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
            count++;
        }
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            count++;
        }
        public double A
        {
            get { return a; }
            set
            {
                Console.Write("A:");
                bool o = Double.TryParse(Console.ReadLine(), out value);
                while (!o)
                {
                    Console.WriteLine("Введите число (если дробное, то используйте запятую)");
                    o = Double.TryParse(Console.ReadLine(), out value);
                }
                while (value < 0)
                {
                    Console.WriteLine("Введите положительное число");
                    o = Double.TryParse(Console.ReadLine(), out value);
                }
                a = value;
                count++;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                Console.Write("B:");
                bool o = Double.TryParse(Console.ReadLine(), out value);
                while (!o)
                {
                    Console.WriteLine("Введите число, (если дробное, то используйте запятую)");
                    o = Double.TryParse(Console.ReadLine(), out value);
                }
                while (value < 0)
                {
                    Console.WriteLine("Введите положительнео число");
                    o = Double.TryParse(Console.ReadLine(), out value);
                }
                b = value;
                count++;
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                Console.Write("C:");
                bool o = Double.TryParse(Console.ReadLine(), out value);
                while (!o)
                {
                    Console.WriteLine("Введите число, (если дробное, то используйте запятую)");
                    o = Double.TryParse(Console.ReadLine(), out value);
                }
                while (value < 0)
                {
                    Console.WriteLine("Введите положительное число");
                    o = Double.TryParse(Console.ReadLine(), out value);
                }
                c = value;
                count++;
            }
        }
        public double SQ1
        {
            get { return Sq1; }
            set
            {
                count++;
                double p = (a + b + c) / 2;
                Sq1 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        //public static void Katet()
        //{
        //    double a;
        //    double b;
        //    double c;
        //    Console.WriteLine("Введите сторону а");
        //    bool o = Double.TryParse(Console.ReadLine(), out a);
        //    while (!o)
        //    {
        //        Console.WriteLine("Введите число");
        //        o = Double.TryParse(Console.ReadLine(), out a);
        //    }
        //    Console.WriteLine("Введите сторону b");
        //    o = Double.TryParse(Console.ReadLine(), out b);
        //    while (!o)
        //    {
        //        Console.WriteLine("Введите число");
        //        o = Double.TryParse(Console.ReadLine(), out b);
        //    }
        //    Console.WriteLine("Введите сторону c");
        //    o = Double.TryParse(Console.ReadLine(), out c);
        //    while (!o)
        //    {
        //        Console.WriteLine("Введите число");
        //        o = Double.TryParse(Console.ReadLine(), out c);
        //    }
        //    if ((a + b) < c) { Console.WriteLine("Такого треугольника не существует"); }
        //    else if ((a + c) < b) { Console.WriteLine("Такого треугольника не существует"); }
        //    else if ((b + c) < a) { Console.WriteLine("Такого треугольника не существует"); }
        //}
        public void Show()
        {
            Console.WriteLine($"Стороны вашего треугольника равны: a - {a}, b - {b}, c - {c}");
        }
        public double ShowSquare2(double a, double b, double c)
        {
            double Sq;
            double p;
            p = (a + b + c) / 2;
            Sq = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            Console.WriteLine($"Площадь треугольника равна {Sq}");
            return Sq;
        }
        public static Triangle operator ++(Triangle t)
        {
            t.a++;
            t.b++;
            t.c++;
            return t;
        }
        public static Triangle operator --(Triangle t)
        {
            t.a--;
            t.b--;
            t.c--;
            return t;
        }
        public static explicit operator double (Triangle t)
        {
            return t.SQ1;
        }
        public static bool operator >=(Triangle t, Triangle t1)
        {
            return t.Sq1 >= t1.Sq1;
        }
        public static bool operator <=(Triangle t, Triangle t1)
        {
            return t.Sq1 <= t1.Sq1;
        }
        //public void ShowSquare()
        //{
        //    Console.WriteLine($"Площадь равна {Sq1}");
        //}
        
    }
}
