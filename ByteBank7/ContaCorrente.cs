using System;

namespace ByteBank7
{
    public class ContaCorrente
    {
        public Cliente Titular { get; private set; }
        public static int TotalDeContasCriadas { get; set; }
        private int _agencia; 
        public int Agencia 
        {
            get
            {
                return _agencia;
            } 
            set
            {
                if ( value <= 0 )
                {
                    return;
                }
                _agencia = value;
            } 
        }
        public int Numero { get; set; }
        
        private double _saldo = 100;
        public double Saldo 
        {
             get
             {
                return _saldo;
             } 
             set
             {
                if ( value < 0 )
                {
                    return;
                }

                _saldo = value;
             } 
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            // incrementa a quantidade de contas a cada uma nova conta criada
        }

        public bool Sacar(double valor)
        {
            if ( this.Saldo < valor )
            {
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
