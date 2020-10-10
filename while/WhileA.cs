using System;
using System.Collections.Specialized;

namespace WhileA
{
    public class WhileA
    {
        static void Main(string[] args)
        {
            return;
        }

        public int While1(int a, int b)
        {
            int P = 0;
            while (a - b > 0)
            {
                a -= b;
                P++;
            }
            return (P);
        }

        static void While5()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            while (n != 2)
            {
                n /= 2;
                k++;
            }
            Console.WriteLine(k);
        }

        static void While9()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int m = 3;
            int k = 1;
            while (n < m + 1)
            {
                m *= 3;
                k++;
            }
            Console.WriteLine(k);
        }

        static void While13()
        {
            int A;
            A = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            double sum = 0;
            while (sum < A)
            {
                sum += 1.0 / k;
                k++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(--k);
        }

        static void While17()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                int k = n % 10;
                n = n / 10;
                Console.WriteLine(k);
            }
        }

        public string While21(int n)
        {
            while (n != 0)
            {
                int k = n % 10;
                n = n / 10;
                if (k % 2 == 1)
                {
                    return ("true");
                }
            }
            return ("false");
        }

        static void While25()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int m1 = 1;
            int m2 = 1;
            while (true)
            {
                if (m1 > n)
                {
                    Console.WriteLine(f1);
                    break;
                }
                if (m2 > n)
                {
                    Console.WriteLine(f2);
                    break;
                }
                m1 = m1 + m2;
                m2 = m1 + m2;
            }
        }

        static void While29()
        {
            double E;
            E = Convert.ToDouble(Console.ReadLine());
            double A2 = 1;
            double A1 = 2;
            int k = 3;
            double A = (A2 + 2 * A1) / k;
            while (true)
            {
                if (Math.Abs(A - A1) < E)
                {
                    Console.WriteLine(k);
                    break;
                }
                A2 = A1;
                A1 = A;
                A = (A2 + 2 * A1) / k;
                k++;
            }
        }
    }
}