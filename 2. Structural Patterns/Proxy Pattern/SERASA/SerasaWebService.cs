using SERASA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERASA
{
    public class SerasaWebService
    {
        /// <summary>
        /// Esse serviço custa caro!
        /// </summary>
        public Cliente ConsultarPessoaFisica(string cpf)
        {
            var cliente = new Cliente()
            {
                Nome = "Joao da Silva",
                Cpf = "011.166.115-90",
                Restricoes = new List<Restricao>
                {
                    new Restricao() { Valor = 150.00m, Data = Convert.ToDateTime("10/10/2014") },
                    new Restricao() { Valor = 400.00m, Data = Convert.ToDateTime("30/11/2014") },
                    new Restricao() { Valor = 300.00m, Data = Convert.ToDateTime("05/12/2014") }
                },
                DataUltimaConsulta = DateTime.Now
            };

            return cliente;
        }
    }
}
