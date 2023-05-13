using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio10
    {
        public static void Executar()
        {
            //Dada uma lista de strings, filtre apenas as strings que não contêm uma determinada subtring.

            List<string> frutas = new List<string> { "maça", "banana", "uva", "laranja"};
            List<string> frutasQueNaoTemSubString = new List<string>();

            for(int index = 0; index < frutas.Count; index++)
            {
                if (!frutas[index].Contains("ana"))
                {
                    frutasQueNaoTemSubString.Add(frutas[index]);
                }
            }
            for(int index = 0; index < frutasQueNaoTemSubString.Count; index++)
            {
                Console.WriteLine(frutasQueNaoTemSubString[index]);
            }
        }

        public static void ExecutarB2()
        {
            List<string> frutas = new List<string> { "maça", "banana", "uva", "laranja" };
            List<string> frutasQueNaoTemSubString = new List<string>();

            foreach(string fruta in frutas)
            {
                if (!fruta.Contains("ana"))
                {
                    frutasQueNaoTemSubString.Add(fruta);
                }
            }

            foreach(string fruta in frutasQueNaoTemSubString) 
            {
                Console.WriteLine(fruta);
;           }
        }

        public static void ExecutarB3() 
        {
            List<string> frutas = new List<string> { "maça", "banana", "uva", "laranja" };
            List<string> frutasQueNaoTemSubString = new List<string>();

           frutasQueNaoTemSubString = frutas.Where(x => !x.Contains("ana")).ToList();

           frutasQueNaoTemSubString.ForEach(x => Console.WriteLine(x));
        }
    }
}
