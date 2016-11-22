using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERASA.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public List<Restricao> Restricoes { get; set; }
        public DateTime DataUltimaConsulta { get; set; }
    }
}
