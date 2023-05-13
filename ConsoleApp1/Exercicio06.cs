using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio06
    {
        public static void Executar()
        {
            //Dada uma lista de dicionários, filtre apenas os dicionários que possuem um valor específico em uma determinada chave.

            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "picachu");
            dic1.Add(2, "raichu");
            dic1.Add(3, "charizard");

            Dictionary<int, string> dic2 = new Dictionary<int, string>();
            dic2.Add(8, "bubassauro");
            dic2.Add(6, "ismael");
            dic2.Add(4, "viado");

            List<Dictionary<int, string>> listaDeDicionarios = new List<Dictionary<int, string>> { dic1, dic2};
            List<Dictionary<int, string>> newListaDicionarios = new List<Dictionary<int, string>> ();

            foreach (Dictionary<int, string> keyValuePairs in listaDeDicionarios) 
            {
                if (keyValuePairs.ContainsKey(6))
                {
                    newListaDicionarios.Add(keyValuePairs);
                }
            }

            foreach(Dictionary<int, string> dicionario in newListaDicionarios)
            {
               foreach(string pokemonName in dicionario.Values)
                {
                    Console.WriteLine(pokemonName);
                }
            }
        }
    }
 }

