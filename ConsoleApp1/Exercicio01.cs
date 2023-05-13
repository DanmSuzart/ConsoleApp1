using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio01
    {
       public static void Executar()
        {


            List<int> numeros = new List<int> { 1, 2, 3, 8, 6, 9 };
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            for (int index = 0; index < numeros.Count; index++)
            {
                if (numeros[index] % 2 == 0)
                {
                    numerosPares.Add(numeros[index]);
                }
                else
                {
                    numerosImpares.Add(numeros[index]);
                }
            }

            numerosPares.ForEach(x => Console.WriteLine(x + " O numero é par"));
            numerosImpares.ForEach(x => Console.WriteLine(x + " O numero é impar"));
        }

       public static void ExecutarB2()
        {

            List<int> numeros = new List<int> { 1, 2, 3, 8, 6, 9 };
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

           foreach (int numero in numeros)
            {
                if(numero % 2 == 0)
                {
                    numerosPares.Add(numero);
                } else
                {
                    numerosImpares.Add(numero);
                }
            }

            foreach(int numero in numerosPares)
            {
                Console.WriteLine(numero + " O numéro é par");
            }

            foreach (int numero in numerosImpares) {
                Console.WriteLine(numero + " O numero é impar");
            }
        }
        public static void ExecutarB3()
        {

            List<int> numeros = new List<int> { 1, 2, 3, 8, 6, 9 };
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();

            numerosPares = numeros.Where(x => x % 2 == 0).ToList();
            numerosImpares = numeros.Where(x => x % 2 != 0).ToList();

            numerosPares.ForEach(x => Console.WriteLine(x + " O numero é par"));
            numerosImpares.ForEach(x => Console.WriteLine(x + " O numero é impar"));
        }
    }
}
