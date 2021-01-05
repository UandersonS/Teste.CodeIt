using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoCodeIT
{
    class SmartForTwo
    {
        Aviao aviao = new Aviao();
        Terminal terminal = new Terminal();

        public void TerminalAteAviao(int index_motorista, int index_passageiro, List<Tripulacao> pessoas)
        {


            var motorista = pessoas[index_motorista].descricao;
            var passageiro = pessoas[index_passageiro].descricao;



            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }

            else
            {
                Console.WriteLine("Trajeto: " + motorista + " leva " + passageiro + " do terminal até o avião.");
                aviao.SetPessoasAviao(index_passageiro, pessoas);
                aviao.SetPessoasAviao(index_motorista, pessoas);
                terminal.RemovePessoasTerminal(index_passageiro, pessoas);
                terminal.RemovePessoasTerminal(index_motorista, pessoas);
            }




        }
        public void AviaoAteTerminal(int index_motorista, int index_passageiro, List<Tripulacao> pessoas)
        {
            var motorista = pessoas[index_motorista].descricao;
            var passageiro = pessoas[index_passageiro].descricao;



            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " leva " + passageiro + " do avião até o terminal.");
                aviao.RemovePessoasAviao(index_passageiro, pessoas);
                aviao.RemovePessoasAviao(index_motorista, pessoas);
                terminal.SetPessoasTerminal(index_passageiro, pessoas);
                terminal.SetPessoasTerminal(index_motorista, pessoas);
            }


        }

        public void TerminalAteAviaoVazio(int index_motorista, List<Tripulacao> pessoas)
        {
            var motorista = pessoas[index_motorista].descricao;




            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " vai sozinho do terminal até o avião.");
                terminal.RemovePessoasTerminal(index_motorista, pessoas);
                aviao.SetPessoasAviao(index_motorista, pessoas);

            }


        }
        public void AviaoAteTerminalVazio(int index_motorista, List<Tripulacao> pessoas)
        {
            var motorista = pessoas[index_motorista].descricao;



            if (pessoas[index_motorista].permissao_dirigir != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir");
            }
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " vai sozinho do avião até o terminal.");
                aviao.RemovePessoasAviao(index_motorista, pessoas);
                terminal.SetPessoasTerminal(index_motorista, pessoas);
            }



        }



    }
}
