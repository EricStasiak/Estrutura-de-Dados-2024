using System;

class Program
{
    static void Main()
    {
        int[] pares = new int[100];
        int[] impares = new int[100];

        int numPares = 0;
        int numImpares = 0;
        int numero = 1;
        while (numPares < 100 || numImpares < 100)
        {
            if (numero % 2 == 0)
            {
                if (numPares < 100)
                {
                    pares[numPares] = numero;
                    numPares++;
                }
            }
            else
            {
                if (numImpares < 100)
                {
                    impares[numImpares] = numero;
                    numImpares++;
                }
            }

            numero++;
        }
        Console.WriteLine("Números Pares:");
        foreach (int par in pares)
        {
            Console.Write(par + " ");
        }

        Console.WriteLine("\n\nNúmeros Ímpares:");
        
        foreach (int impar in impares)
        {
            Console.Write(impar + " ");
        }

        Console.WriteLine();
    }
}