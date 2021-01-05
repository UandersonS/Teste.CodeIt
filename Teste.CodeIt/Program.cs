using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliacaoCodeIT
{
    class Program
    {
        static SmartForTwo trajeto = new SmartForTwo();
        static Aviao aviao = new Aviao();
        static Terminal terminal = new Terminal();

        static void Main(string[] args)
        {
            Console.WriteLine("INICIO");


            Tripulacao tripulacao = new Tripulacao();
            var pessoas = tripulacao.carregaPessoas();

          

            terminal.carregaTerminal(pessoas);
            lista();

            /*Trajeto*/
            //Policial leva Presidiario/  
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[7].index, pessoas);
            lista();

            //Policial volta sem ninguem/
            trajeto.AviaoAteTerminalVazio(pessoas[6].index, pessoas);
            lista();

            //Policial leva Oficial 1/
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[1].index, pessoas);
            terminal.ListaTerminal();
            aviao.ListaAviao();

            //Policial volta com o presidiario/
            trajeto.AviaoAteTerminal(pessoas[6].index, pessoas[7].index, pessoas);
            lista();


            //Piloto leva oficial 2
            trajeto.TerminalAteAviao(pessoas[0].index, pessoas[2].index, pessoas);
            lista();

            //Piloto Volta sozinho
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);
            lista();


            //Chefe de serviço leva Piloto
            trajeto.TerminalAteAviao(pessoas[3].index, pessoas[0].index, pessoas);
            lista();


            //Chefe de serviço volta sozinho
            trajeto.AviaoAteTerminalVazio(pessoas[3].index, pessoas);
            lista();

            //Policial leva Presidiario/  
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[7].index, pessoas);
            lista();


            //Piloto volta sozinho
            trajeto.AviaoAteTerminalVazio(pessoas[0].index, pessoas);
            lista();


            //Chefe de serviço leva o piloto
            trajeto.TerminalAteAviao(pessoas[3].index, pessoas[0].index, pessoas);
            lista();

            //Chefe de serviço volta sozinho
            trajeto.AviaoAteTerminalVazio(pessoas[3].index, pessoas);
            lista();


            //Chefe de serviço leva comissaria 1
            trajeto.TerminalAteAviao(pessoas[3].index, pessoas[4].index, pessoas);
            lista();



            //Policial leva presidiário do avião até o terminal
            trajeto.AviaoAteTerminal(pessoas[6].index, pessoas[7].index, pessoas);
            lista();




            //Policial leva comissária 2 até o avião
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[5].index, pessoas);
            lista();



            //Policial volta sem ninguem 
            trajeto.AviaoAteTerminalVazio(pessoas[6].index, pessoas);
            lista();



            //Policial leva presidiário até o avião
            trajeto.TerminalAteAviao(pessoas[6].index, pessoas[7].index, pessoas);
            lista();


            Console.WriteLine("FIM");


        }

        public static void lista()
        {
            terminal.ListaTerminal();
            aviao.ListaAviao();
            Console.WriteLine("\nAperte Enter para prosseguir o algoritmo\n");
            Console.ReadLine();
        }

    }
}
