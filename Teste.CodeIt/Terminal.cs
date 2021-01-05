using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoCodeIT
{
    class Terminal 
    {
        static List<string> terminalList = new List<string>();

        public void carregaTerminal(List<Tripulacao> pessoas)
        {

            foreach (Tripulacao pessoa in pessoas)
            {
                terminalList.Add(pessoa.descricao);
            }


        }


        public void SetPessoasTerminal(int index_pessoa, List<Tripulacao> pessoas)
        {

            terminalList.Add(pessoas[index_pessoa].descricao);

        }

        public void RemovePessoasTerminal(int index_pessoa, List<Tripulacao> pessoas)
        {
            terminalList.Remove(pessoas[index_pessoa].descricao);

        }
        
        public void ListaTerminal()
        {
            Console.WriteLine("");
            Console.WriteLine("======Pessoas no Terminal=======");
            Console.WriteLine("========================");
            if (terminalList.Count == 0)
            {
                Console.WriteLine("Ninguém está no Terminal");
            }
            else 
            {
                foreach (string pessoa in terminalList)
                {
                    Console.WriteLine(pessoa);
                }
            }
          
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
