using System;

namespace _4._1_15v
{
    class Program
    {
        static void Main(string[] args)
        {
           // 4.1 15v Средний уровень
            Console.WriteLine("Введите вещественное число S:");
            double S = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер массива n:");
            int n = int.Parse(Console.ReadLine());
            double[] mas= new double[n];
            Random random = new Random();
            
                for (int j = 0; j < n; j++)
                {
                    mas[j] = random.NextDouble() * 100; 
                    Console.Write("{0,6:F2}", mas[j]);
                }
                Console.WriteLine();
            double temp = 0, t = double.MinValue;

            for (int i = 0; i < mas.Length; i++)
            {
                double a = Math.Abs(Math.Abs(mas[i]) - Math.Abs(S));

                if (t < a)
                {
                    temp = mas[i];
                    t = a;
                }
            }

            Console.WriteLine("Наиболее удаленное число к S: {0:F2}", temp);

        }
    }
}
    