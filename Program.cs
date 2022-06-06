using System;

namespace SOLID_LSP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cliente cliente = new ClienteContratado(DateTime.Now, "Fabricio Silva");
            var premium = cliente.ClientePremium();

            Console.WriteLine("Cliente Premium: " + premium.ToString());
        }
    }
}