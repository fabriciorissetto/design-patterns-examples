using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serasaService = new SerasaProxy();

            var consulta1 = serasaService.ConsultarPessoaFisica("011.166.115-90");
            var consulta2 = serasaService.ConsultarPessoaFisica("011.166.115-90");

            for (int i = 0; i < 30; i++)
            {
                var consulta = serasaService.ConsultarPessoaFisica(Guid.NewGuid().ToString());
            }
        }
    }
}
