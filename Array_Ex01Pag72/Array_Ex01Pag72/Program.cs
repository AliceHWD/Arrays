using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Ex01Pag72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] =  int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nValores colocados:");

            foreach (int valor in valores)
            {         
                Console.WriteLine(valor);
            }
           
            Console.ReadLine();
        }
    }
}
