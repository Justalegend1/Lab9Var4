using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Var4
{
    public class TriangleArray
    {
        int sposob;
        Triangle[] arr;
        public int Length
        {
            get { return arr.Length; }
        }
        static Random rnd = new Random();
        public TriangleArray()
        {
            arr = null;
            Triangle.count++;
        }
        public TriangleArray(int size)
        {
            arr = new Triangle[size];
            for (int t = 0; t < size; t++)
            {
                Console.WriteLine("Выберите способ заполнения массива:\n1 - Датчик случайных чисел\n2 - Ручной ввод");
                bool o = Int32.TryParse(Console.ReadLine(), out sposob);
                while (!o)
                {
                    Console.WriteLine("Введите целое число");
                    o = Int32.TryParse(Console.ReadLine(), out sposob);
                }
                while (sposob < 1 | sposob > 2)
                {
                    Console.WriteLine("Выберите способ 1 или 2");
                    o = Int32.TryParse(Console.ReadLine(), out sposob);
                }
                if (sposob == 1)
                {
                    Triangle r = new Triangle();
                    r.a = Convert.ToDouble(rnd.Next(0, 10));
                    r.b = Convert.ToDouble(rnd.Next(0, 10));
                    r.c = Convert.ToDouble(rnd.Next(0, 10));
                    if ((r.a + r.b < r.c) | (r.b + r.c < r.a) | (r.c + r.a < r.b))
                    {
                        r.Sq1 = 0;
                        Console.WriteLine("Такого треугольника не существует");
                    }
                    else
                        r.ShowSquare2(r.A, r.B, r.C);
                    arr[t] = r;
                }
                if (sposob == 2)
                {
                    Triangle r = new Triangle();
                    r.A = 1;
                    r.B = 1;
                    r.C = 1;
                    if ((r.a + r.b < r.c) | (r.b + r.c < r.a) | (r.c + r.a < r.b))
                    {
                        r.Sq1 = 0;
                        Console.WriteLine("Такого треугольника не существует");
                    }
                    else
                        r.Sq1 = r.ShowSquare2(r.A, r.B, r.C);
                    Triangle.count++;
                }
            }
        }
        public void Show()
        {
            foreach (Triangle x in arr)
                x.ShowSquare2(x.a, x.b, x.c);
        }
        public void ShowSquare()
        {
            foreach (Triangle t in arr)
                Console.WriteLine($"Площадь равна {arr}");
        }
        public Triangle this[int index]
        {
            get { return arr[index]; }
            set
            {
                arr[index] = value;
            }
        }

    }
}