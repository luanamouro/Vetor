using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[15];
            double[] b = new double[15];

            Console.WriteLine("Inverter Vetor\n\n");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Digite o {0}º elemento do vetor A", i + 1);
                a[i] = Convert.ToDouble(Console.ReadLine());
                b[(a.Length - 1) - i] = a[i];

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(b[1].ToString());
            }

        }
    }
}
