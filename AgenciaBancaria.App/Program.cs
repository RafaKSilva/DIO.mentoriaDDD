using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco =  new Endereco("Alzira Bezera", "25105195", "Sorocaba","São Paulo");
            Cliente cliente = new Cliente("Carla","123.456.789-10","18822822-65", endereco);
            ContaCorrente conta = new ContaCorrente(cliente,1000.0M); 

            Console.WriteLine($"Conta: {conta.Situacao} - {conta.NumeroConta}-{conta.DigitoVerificador}"); 
            string senha = "abc12345";
            conta.Abrir(senha);
            Console.WriteLine($"Conta: {conta.Situacao} - {conta.NumeroConta}-{conta.DigitoVerificador}");                      
            conta.Sacar(10,senha);
            Console.WriteLine($"Saldo: {conta.Saldo}");
        }
    }
}
