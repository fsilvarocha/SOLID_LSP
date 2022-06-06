using System;

namespace SOLID_LSP
{
    public class ClienteProspectado : Cliente
    {
        public DateTime DataProspectado { get; set; }

        public ClienteProspectado(DateTime dataProspectado, string nome)
        {
            DataProspectado = dataProspectado;
            Nome = nome;
        }

        public override bool ClientePremium()
        {
            //não poderia ter esse método,
            throw new NotImplementedException();
        }
    }
}