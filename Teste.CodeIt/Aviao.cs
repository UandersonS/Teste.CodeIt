using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoCodeIT
{
    class Aviao 
    {

        static  List<string> aviaoList = new List<string>();
        
  
        public void SetPessoasAviao(int index_pessoa, List<Tripulacao> pessoas){
             
            aviaoList.Add(pessoas[index_pessoa].descricao);
            
        }

        public void RemovePessoasAviao(int index_pessoa, List<Tripulacao> pessoas)
        {
            aviaoList.Remove(pessoas[index_pessoa].descricao);
            
        }

            public void ListaAviao()
        {
            Console.WriteLine("");
            Console.WriteLine("======Pessoas no Avião=======");
            Console.WriteLine("========================");
            if (aviaoList.Count == 0)
            {
                Console.WriteLine("Ninguém está no Avião");
            }
            else
            {
                foreach (string pessoa in aviaoList)
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
