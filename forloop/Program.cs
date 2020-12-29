using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Printing 1 to 10 ");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                //Console.Write(i);
            }
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int j = 0; j <= num; j++)
            {
                sum = sum + j;
            }
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("Enter 2 Numbers :");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double r = Math.Pow(m, n);
            Console.WriteLine(r);
            int h = 1;
            for(int i = 1; i <= n; i++)
            {
                h = h * m;
            }
            Console.WriteLine("value is " + h);
        }
    }
}
