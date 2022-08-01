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

            GerenciaBonificacao gerenciador = new GerenciaBonificacao();

            Funcionario Gabriel = new Funcionario();
            Gabriel.Nome = "Gabriel";
            Gabriel.CPF = "546.879.157-20";
            Gabriel.Salario = 2000;

            gerenciador.Registrar(Gabriel);

            Diretor Julia = new Diretor();
            Julia.Nome = "Julia";
            Julia.CPF = "454.658.148-30";
            Julia.Salario = 5000;

            gerenciador.Registrar(Julia);

            Console.WriteLine(Gabriel.Nome + ": " + Gabriel.GetBonificacao());
            Console.WriteLine(Julia.Nome + ": " + Julia.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}