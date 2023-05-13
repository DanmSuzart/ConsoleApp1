using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio05
    {
        public static void Executar()
        {
            //Dada uma lista de strings, filtre apenas as strings que contêm uma determinada subtring.

            List<string> list = new List<string> { "Raichu", "Banana", "Tomate", "Torre", "Picachu"};
            List<string> listaContemSubstring = new List<string>();

            for(int index = 0; index < list.Count; index++)
            {
                if (list[index].Contains("chu"))
                {
                    listaContemSubstring.Add(list[index]);
                }
            }

            for(int index = 0; index < listaContemSubstring.Count; index++)
            {
                Console.WriteLine(listaContemSubstring[index]);
            }

        }

        public static void ExecutarB2()
        {
            List<string> list = new List<string> { "Raichu", "Banana", "Tomate", "Torre", "Picachu" };
            List<string> listaContemSubstring = new List<string>();

            foreach(string item in list)
            {
                if (item.Contains("chu"))
                {
                    listaContemSubstring.Add(item); 
                }
            }
            foreach(string item in listaContemSubstring)
            {
                Console.WriteLine(item);
            }

        }
        public static void ExecutarB3()
        {
            List<string> list = new List<string> { "Raichu", "Banana", "Tomate", "Torre", "Picachu" };
            List<string> listaContemSubstring = new List<string>();

            listaContemSubstring = list.Where(x => x.Contains("chu")).ToList();

            listaContemSubstring.ForEach(item =>  Console.WriteLine(item));
        }
    }
}
