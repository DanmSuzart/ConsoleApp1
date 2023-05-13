using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio09
    {
        public static void Executar()
        {
           // Dada uma lista de dicionários, filtre apenas os dicionários que possuem um valor maior do que um determinado número em uma determinada chave. 

            Dictionary<int, string> dicionario = new Dictionary<int, string>();
            dicionario.Add(1, "cenoura");
            dicionario.Add(2, "batata");
            dicionario.Add(3, "maça");

            Dictionary<int, string> dicionario2 = new Dictionary<int, string>();
            dicionario2.Add(1, "picachu");
            dicionario2.Add(2, "charizard");
            dicionario2.Add(3, "bulba");

            List<Dictionary<int, string>> listaDeDicionario = new List<Dictionary<int, string>> { dicionario2, dicionario2 };
            List<Dictionary<int, string>> listaDeDicionario2 = new List<Dictionary<int, string>>();


            foreach(Dictionary<int, string> itens in listaDeDicionario)
            {
                if(!itens.Keys.Contains(2))
                {
                    listaDeDicionario2.Add(itens);
                }
            }

            foreach(Dictionary<int, string> item in listaDeDicionario2)
            {
                foreach(string itens in item.Values)
                {
                    Console.WriteLine(itens);
                }
            }
        }
    }
}
