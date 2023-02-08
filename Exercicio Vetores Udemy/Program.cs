using System;
using System.Globalization;
namespace MaiorNumeroVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double[] numeros = new double[n];
            double maior = 0;
            int posicao = 0;

            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {

                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
            Console.ReadLine();
        }
    }
}