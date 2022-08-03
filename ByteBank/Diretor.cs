using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            
        }
        public override double GetBonificacao()
        {
            return Salario + (base.GetBonificacao());
            // Retorna o salario somado a bonificação padrão para funcionários
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}