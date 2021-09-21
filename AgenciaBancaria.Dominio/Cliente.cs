using System;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente(string nome,string cpf, string rg, Endereco endereco)
        {
            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();
            Endereco = endereco ?? throw new Exception("O endereço deve ser informado.");
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; } 
        public string RG { get; private set; }  

        public Endereco Endereco { get; private set; }
    }

}