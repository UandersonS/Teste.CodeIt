using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoCodeIT
{
    class Tripulacao
    {

        public int index { get; set; }
        public int id { get; set; }

        public int lider { get; set; }
        public int permissao_dirigir { get; set; }
        public int grupo { get; set; }
        public string descricao { get; set; }

        //Função para carregar as pessoas
        public List<Tripulacao> carregaPessoas()
        {
            var tripulacaoLista = new List<Tripulacao>
            {
                new Tripulacao { index = 0, id = 1, lider=1, permissao_dirigir=1, grupo=1,descricao="Piloto"},
                new Tripulacao { index = 1, id = 2, lider=0, permissao_dirigir=0, grupo=1,descricao="Oficial 1"},
                new Tripulacao { index = 2, id = 3, lider=0, permissao_dirigir=0, grupo=1,descricao="Oficial 2"},
                new Tripulacao { index = 3, id = 4, lider=1, permissao_dirigir=1, grupo=2,descricao="Chefe de Serviço"},
                new Tripulacao { index = 4, id = 5, lider=0, permissao_dirigir=0, grupo=2,descricao="comissária 1"},
                new Tripulacao { index = 5, id = 6, lider=0, permissao_dirigir=0, grupo=2,descricao="comissária 2"},
                new Tripulacao { index = 6, id = 7, lider=1, permissao_dirigir=1, grupo=3,descricao="Policial"},
                new Tripulacao { index = 7, id = 8, lider=1, permissao_dirigir=0, grupo=3,descricao="Presidiário"}
            };

            return tripulacaoLista;

        }

    }
}
