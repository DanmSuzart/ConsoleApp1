using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio03
    {
        public static void Executar()
        {
            //Dada uma lista de strings, filtre apenas as strings que possuem mais de 5 caracteres.OK

            List<string> list = new List<string> {"Banana", "Pokemon", "Ave", "Bolsa" };
            List<string> list2 = new List<string>();

            for(int index = 0 ; index < list.Count; index++)
            {
                if (list[index].Length > 5)
                {
                    list2.Add(list[index]);
                }
            }
            for(int index = 0 ;index < list2.Count; index++)
            {
                Console.WriteLine(list2[index]);
            }
        }
        public static void ExecutarB2()
        {

            List<string> list = new List<string> { "Banana", "Pokemon", "Ave", "Bolsa" };
            List<string> list2 = new List<string>();

            foreach(string item in list)
            {
                if(item.Length > 5)
                {
                    list2.Add(item);
                }
            }

            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }
        }

        public static void ExecutarB3()
        {

            List<string> list = new List<string> { "Banana", "Pokemon", "Ave", "Bolsa" };
            List<string> list2 = new List<string>();

            list2 = list.Where(x => x.Length > 5).ToList();

            list2.ForEach(x => Console.WriteLine(x));
            
        }
    }
}
