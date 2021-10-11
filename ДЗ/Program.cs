using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s, k, c, z;
            char m;
            Console.Write("Введите числитель: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите числитель: ");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знамнатель: ");
            k = Convert.ToDouble(Console.ReadLine());
            {
                c = a / b; Console.WriteLine(a + "/" + b + "=" + c);
                z = s / k; Console.WriteLine(s + "/" + k + "=" + z);
                double p;
                Console.Write("Введите действие: ");
                m = Convert.ToChar(Console.ReadLine());
                switch (m)
                {
                    case '+': p = (c + z); Console.WriteLine(c + " + " + z + " = " + p); break;
                    case '-': p = (c - z); Console.WriteLine(c + " - " + z + " = " + p); break;
                    case '*': p = (c * z); Console.WriteLine(c + " * " + z + " = " + p); break;
                    case '/': p = (c / z); Console.WriteLine(c + " / " + z + " = " + p); break;
                }
                if (m >= 0) 
                {
                    Console.WriteLine("+"); 
                }
                else
                {
                    Console.WriteLine("-");
                }
                Console.ReadKey();
            }

        }
    }
}

    
