using System;

namespace Decorator
{
    public interface IPessoa
    {
        string Nome { get; set; }
        void PagarBoleto();
    }

    public interface IAprendendoPagarContaPeloCelular : IPessoa
    {
    }


    public class Pessoa : IPessoa
    {
        public String Nome { get; set; }

        public Pessoa(String nome)
        {
            this.Nome = nome;
        }

        public void PagarBoleto()
        {
            Console.WriteLine($"To na fia do banco para pagar boleto do {Nome}");
        }
    }

    public class PessoaMaisEsperta : IAprendendoPagarContaPeloCelular
    {
        public IPessoa Pessoa { get; set; }
        public string Nome { get; set; }

        public PessoaMaisEsperta(IPessoa pessoa)
        {
            Pessoa = pessoa;
            Nome = pessoa.Nome;
        }

        public void PagarBoleto()
        {
            Console.WriteLine($"Antes eu pagava boleto assim: ");
            Pessoa.PagarBoleto();

            Console.WriteLine("Agora eu pago assim: ");
            Console.WriteLine($"Estou pagando o boleto de {Nome} Pelo app do banco");
        }
    }
}