using System;

namespace Spiral_n_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n;          
            bool result = int.TryParse(Console.ReadLine(), out n);
            while (result == false)
            {
                Console.WriteLine("Перепроверьте число и введите снова");
                result = int.TryParse(Console.ReadLine(), out n);
            }
            int m = n;
            int[,] mas = new int[m, n];
            int k = 1;
            int t = 0;
            int i, j = 0;
            int n1 = n;
            int m1 = m;

            while (k <= n1 * m1)
            {
                for (i = t; i < n; i++)
                    mas[j, i] = k++;
                j = n - 1;
                for (i = t + 1; i < m; i++)
                    mas[i, j] = k++;
                j = m - 1;
                for (i = n - 2; i >= t; i--)
                    mas[j, i] = k++;
                j = t;
                for (i = m - 2; i > t; i--)
                    mas[i, j] = k++;
                n--;
                m--;
                t++;
                j = t;
            }
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n1; j++)
                    Console.Write("{0,4} ", mas[i, j]);
                Console.WriteLine();
            }
        }
    }
}
