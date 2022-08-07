using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            // Funcionario Gabriel = new Funcionario();
            // List<Funcionario> funcionario = new List<Funcionario>();
            // funcionario.Add(Gabriel);

            // foreach (var p in funcionario)
            // {
            //     Console.WriteLine(p.Nome);
            //     Console.WriteLine(p.CPF);
            //     Console.WriteLine(p.Salario);
            // }
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("\nTecle enter para sair...");
            Console.ReadLine();
        }
    }
}