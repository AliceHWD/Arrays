using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ex02Pag72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iValores = 0;
            int[] valores = new int[5];

            Console.WriteLine("Escreva cinco números: ");
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nValores maiores que 50:");

            foreach (int valor in valores)
            {
                if (valor > 50)
                {
                    Console.WriteLine(valor);
                    iValores++;
                }

            }

            if (iValores == 0)
                Console.WriteLine("Não contém.");

            Console.ReadLine();
        }
    }
}
