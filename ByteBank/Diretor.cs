using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            Salario = 5000;
        }
        public override double GetBonificacao()
        {
            return Salario *= 1.1;
            // Retorna o salario somado a bonificação padrão para funcionários
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}