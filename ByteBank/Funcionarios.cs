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
        public virtual void AumentarSalario()
        {
            // Salario = Salario * 1.1;
            Salario *= 1.1;
        }
        
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}