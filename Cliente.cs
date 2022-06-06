namespace SOLID_LSP
{
    public abstract class Cliente
    {
        public string Nome { get; set; }

        public abstract bool ClientePremium();
    }
}