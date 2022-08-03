using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }
        public Funcionario (double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
        }
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}