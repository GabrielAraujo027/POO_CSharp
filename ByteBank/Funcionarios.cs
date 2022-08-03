using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    // Uma classe abstrata não pode ser criada individualmente, deve-se instanciar as classes herdadas.
    
    // Lembrar de implementar as alterações feitas ao longo do curso 3 de c#, além de adicionar outros
    // detalhes para enriquecer o projeto
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }
        public Funcionario (string cpf)
        {
            CPF = cpf;
        }
        public Funcionario (double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
        }
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}