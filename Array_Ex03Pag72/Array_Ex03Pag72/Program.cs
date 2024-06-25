using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ex03Pag72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];

            Console.WriteLine("Escreva cinco números:");

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);
            Console.WriteLine($"\nMaior valor: {valores[4]}");
            Console.ReadLine();
        }
    }
}
