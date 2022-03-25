namespace Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPessoa Paulo = new PessoaMaisEsperta(new Pessoa("Paulo Raitz"));
            Paulo.PagarBoleto();
        }
    }
}