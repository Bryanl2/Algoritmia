using System;
using System.Diagnostics;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            double result = 0;

            sw.Start();
            result = Factorial(50);
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resultado del factorial de 5 es {0} con un total de tiempo de {1}", result,sw.ElapsedTicks);


            Stopwatch swp = new Stopwatch();
            sw.Reset();
            swp.Start();
            result = Clasico(50);
            swp.Stop();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Resultado del factorial de 5 es {0} con un total de tiempo de {1}", result, swp.ElapsedTicks);
            
            Console.ReadKey();

            //Fibonacci
            sw.Reset();
            swp.Reset();
            int[] results = new int[10];
            results = FibonacciClasico(10);
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resultado del factorial de 5 es {0} con un total de tiempo de {1}", results, sw.ElapsedTicks);

            Console.ReadKey();
            var res = Fibonacci(10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resultado del factorial de 5 es {0} con un total de tiempo de {1}", results, sw.ElapsedTicks);

            Console.ReadKey();



        }

        public static double Factorial(int n) 
        {
            double r = 0;
            //Caso inductivo
            if(n >1)
            {
                r = n * Factorial(n - 1);
            }

            //Caso base
            if (n == 1) 
            {
                r = 1;
            }

            return r;
        }

        public static double Clasico(int n) 
        {
            double r = 1;

            for (int i = 1; i < n; i++)
            {
                r = r * (i+1);
            }

            return r;
        }

        public static int Fibonacci(int n) 
        {
            int o = 0;

            //Caso inductivo

            if (n >= 1)
            {
                o = Fibonacci(n - 2) + Fibonacci(n - 1);
            }
            //Caso Base

            if(n == 0) 
            {
                o = 1;
            }
            return o;
        }

        public static int[] FibonacciClasico(int n)
        {
            int posterior = 0;
            int anterior = 0;
            int aux = 0;

            int[] array = new int[n+1];

            for (int i = 0; i<=n; i++)
            {
                posterior = posterior + aux;
                aux = anterior;
                anterior = posterior;
                array[i] = posterior;
                if (i == 0)
                {
                    posterior = i + 1;
                }
            }
            return array;
        }
    }
}
