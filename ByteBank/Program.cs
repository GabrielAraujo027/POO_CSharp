using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Gabriel = new Funcionario();

            Gabriel.nome = "Gabriel";
            Gabriel.CPF = "111.222.333-44";
            Gabriel.Salario = 1297.00;

            Console.WriteLine(Gabriel.GetBonificacao());
            Console.ReadLine();
        }
    }
}
