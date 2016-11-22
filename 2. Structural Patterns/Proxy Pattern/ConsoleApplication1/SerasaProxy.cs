using SERASA;
using SERASA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SerasaProxy : SerasaWebService
    {
        private static List<Cliente> clientesConsultados;
        private static int quantidadeConsultas;

        public SerasaProxy()
        {
            if (clientesConsultados == null)
                clientesConsultados = new List<Cliente>();
        }

        public Cliente ConsultarPessoaFisica(string cpf)
        {
            var cliente = clientesConsultados.FirstOrDefault(x => x.Cpf == cpf);
            if (cliente != null)
                return cliente;

            if (quantidadeConsultas > 10)
            {
                throw new Exception("Limite de consutas atingido!");
            }
            else
            {
                var novoClienteConsultado = base.ConsultarPessoaFisica(cpf);
                clientesConsultados.Add(novoClienteConsultado);
                quantidadeConsultas++;

                return novoClienteConsultado;
            }
        }
    }
}
