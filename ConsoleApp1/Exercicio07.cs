using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio07
    {
        public static void Executar()
        {

            // Dada uma lista de dicionários, filtre apenas os dicionários que possuem um valor específico em uma determinada chave.

            Dictionary<int, string> dicionario = new Dictionary<int, string>();
            dicionario.Add(1, "picachu");
            dicionario.Add(2, "raichu");
            dicionario.Add(3, "bubassauro");


            Dictionary<int, string> dicionario2 = new Dictionary<int, string>();
            dicionario2.Add(1, "charizard");
            dicionario2.Add(2, "raichu");
            dicionario2.Add(3, "charmander");

            List<Dictionary<int, string>> listasDeDicionarios = new List<Dictionary<int, string>> { dicionario, dicionario2 };
            List<Dictionary<int, string>> newListasDeDicionarios = new List<Dictionary<int, string>> ();


            foreach (Dictionary<int, string> pokemons in listasDeDicionarios)
            {
                bool containChave = pokemons.ContainsKey(2);
                if (containChave)
                {
                    var pokemon = pokemons.GetValueOrDefault(2);
                    if(pokemon == "raichu")
                    {
                        newListasDeDicionarios.Add(pokemons);
                    }
                }

            }

            foreach(Dictionary<int, string> pokemon in newListasDeDicionarios)
            {
                foreach(string pokemonName in pokemon.Values)
                {
                    Console.WriteLine(pokemonName);
                }
            }

        }
    }
}
