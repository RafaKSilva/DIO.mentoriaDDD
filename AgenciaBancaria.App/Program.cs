using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
           Cliente cliente = new Cliente("Carla",
                                        "123.456.789-10",
                                        "18822822-65",
                                        "Alzira Bezera",
                                        "25105195",
                                        "Sorocaba",
                                        "São Paulo");
        }
    }
}
