using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main()
        {
            try
            {
                Endereco endereco = new("Rua Teste",
                                                 "00000000",
                                                 "Rio de Janeiro",
                                                 "RJ");

                Cliente cliente = new("Steph",
                                              "12345678900",
                                              "123456789",
                                              endereco);

                ContaCorrente conta = new(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                                                                        conta.DigitoVerificador);

                string senha = "abc12345";
                conta.Abrir(senha);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" +
                                                                        conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}