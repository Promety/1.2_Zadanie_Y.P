using System;
namespace _1._22_Zadanie_Y.P
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double d;
            Console.WriteLine("Введите число а ");
             a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b ");
             b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c ");
             c = double.Parse(Console.ReadLine());

            double x1, x2;
           
             d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (d == 0) 
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else 
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                }
               
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
     
            }
        }
    }
}
   
