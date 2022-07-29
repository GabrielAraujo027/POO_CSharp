using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank7
{
    public class Cliente
    {
        public string Nome { get; set; } = "null";

        private string _cpf = "null";
        public string CPF 
        {
            get
            {
                return _cpf;
            } 
            set
            {
                // escrevo minha lógica de validaçõa de cpf
                _cpf = value;
            }
        }
        
        public string Profissao { get; set;} = "null";
    }
}