using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio02
    {
        public static void Executar()
        {
            List<string> nomes = new List<string> { "daniel", "ana", "ismael"};
            List<string> contemALetra = new List<string>();

            contemALetra = nomes.Where(x => x.Contains('s')).ToList();

            foreach(string str in contemALetra)
            {
                Console.WriteLine(str);
            }
            
        }
        public static void ExecutarB2()
        {
            List<string> nomes = new List<string> { "daniel", "ana", "ismael" };
            List<string> contemALetra = new List<string>();
            
            for(int i = 0; i < nomes.Count; i++) 
            {
                if (nomes[i].Contains('s'))
                {
                    contemALetra.Add(nomes[i]);
                }
            }

            for(int i = 0; i < contemALetra.Count; i++)
            {
                Console.WriteLine(contemALetra[i]);
            }
            
        }
        public static void ExecutarB3()
        {
            List<string> nomes = new List<string> { "daniel", "ana", "ismael" };
            List<string> contemALetra = new List<string>();

            foreach(string str in nomes)
            {
                if (str.Contains('s'))
                {
                    contemALetra.Add(str);
                }
            }
            foreach(string str in contemALetra) { Console.WriteLine(str); }
        }
    }
}
