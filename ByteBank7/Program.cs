using System;

namespace ByteBank7
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 86712540);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}