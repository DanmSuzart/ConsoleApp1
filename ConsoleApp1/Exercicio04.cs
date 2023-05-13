using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio04
    {
        public static void Executar()
        {
            //Dada uma lista de números, filtre apenas os números que são múltiplos de 3.

            List<int> numeros = new List<int> {1, 2, 3, 7, 8, 34, 0, 9 ,33};
            List<int> multiplos = new List<int>();

            for(int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] % 3 == 0)
                {
                    multiplos.Add(numeros[i]);
                }
            }

            for(int i = 0; i < multiplos.Count; i++)
            {
                Console.WriteLine(multiplos[i]);
            }
        }
        public static void ExecutarB2()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 7, 8, 34, 0, 9, 33 };
            List<int> multiplos = new List<int>();

            foreach(int i in numeros)
            {
                if(i %3 == 0)
                {
                    multiplos.Add(i);
                }
            }

            foreach(int i in multiplos)
            {
                Console.WriteLine(i);
            }
        }

        public static void ExecutarB3()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 7, 8, 34, 0, 9, 33 };
            List<int> multiplos = new List<int>();

            multiplos = numeros.Where(x => x % 3 == 0).ToList();

            multiplos.ForEach(x => Console.WriteLine(x));
            
        }
    }
}
