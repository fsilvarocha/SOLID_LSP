using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP
{
    public class ClienteContratado : Cliente
    {
        public DateTime DataCadastro { get; set; }

        public ClienteContratado(DateTime dataCadastro, string nome)
        {
            DataCadastro = dataCadastro;
            Nome = nome;
        }
        public override bool ClientePremium()
        {
            return DataCadastro.Year <= 2017;
        }
    }
}
