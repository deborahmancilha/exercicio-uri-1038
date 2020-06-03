using System;
using System.Globalization;

namespace ex1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double c1, c2, c3, c4, c5;

            String[] vet;
            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            c1 = (double)quantidade * 4.00;
            c2 = (double)quantidade * 4.50;
            c3 = (double)quantidade * 5.00;
            c4 = (double)quantidade * 2.00;
            c5 = (double)quantidade * 1.50;


            if (codigo == 1)
            {
                Console.WriteLine("Total: R$ " + c1.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {
                if (codigo == 2)
                {
                    Console.WriteLine("Total: R$ " + c2.ToString("F2", CultureInfo.InvariantCulture));

                }
                else
                {
                    if (codigo == 3)
                    {
                        Console.WriteLine("Total: R$ " + c3.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        if (codigo == 4)
                        {
                            Console.WriteLine("Total: R$ " + c4.ToString("F2", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            Console.WriteLine("Total: R$ " + c5.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }

        }
    }
}
