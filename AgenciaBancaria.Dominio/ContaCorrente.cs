using System;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Cliente cliente, decimal limite) : base(cliente)
        {
            Limite = limite;
            ValorTaxaManutecao = 0.05M;
        }

        public override void Sacar(decimal valor, string senha)
        {
            if(Senha != senha)
            {
                throw new Exception("Senha inválida");
            }

            if ((Saldo + Limite) < valor)
            {
                throw new Exception("Saldo insuficiente");
            }

            Saldo -= valor;
        }

        public decimal Limite { get; private set; }
        public decimal ValorTaxaManutecao { get; private set; }
    }
}