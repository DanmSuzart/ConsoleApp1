using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio08
    {
        public static void Executar()
        {
            // Dada uma lista de números, filtre apenas os números que estão dentro de um determinado intervalo.


            List<int> numeros = new List<int> { 1, 5, 84, 9, 4, 74 ,44, 8};
            List<int> newNumerosList = new List<int>();

            for(int index = 0; index < numeros.Count; index++)
            {
                if (numeros[index] > 1 && numeros[index] < 10)
                {
                    newNumerosList.Add(numeros[index]);
                }
            }

            for (int index = 0; index < newNumerosList.Count; index++)
            {
                Console.WriteLine(newNumerosList[index]);
            }
        }

        public static void ExecutarB2()
        {
            List<int> numeros = new List<int> { 1, 5, 84, 9, 4, 74, 44, 8 };
            List<int> newNumerosList = new List<int>();

            foreach(int numero in numeros)
            {
                if(numero > 1 && numero < 10)
                {
                    newNumerosList.Add(numero);
                }
            }
            foreach(int numero in newNumerosList)
            {
                Console.WriteLine(numero);
            }
        }

        public static void ExecutarB3()
        {
            List<int> numeros = new List<int> { 1, 5, 84, 9, 4, 74, 44, 8 };
            List<int> newNumerosList = new List<int>();

            newNumerosList =  numeros.Where(x => x > 1 && x < 10).ToList();
            newNumerosList.ForEach(x => Console.WriteLine(x));
        }

    }
}
 