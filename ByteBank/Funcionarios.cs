using System;

namespace ByteBank
{
    public class Funcionario 
    {
        public string nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        // Se cria um método ao inés de um get simples quando existe um cálculo, um custo de processamento
        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}