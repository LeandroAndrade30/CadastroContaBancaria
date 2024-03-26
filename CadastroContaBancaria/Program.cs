using System;

namespace CadastroContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine("Deseja realizar um depósito inicial na sua conta?(s/n)");
            char resposta = char.Parse(Console.ReadLine());

            ContaBancaria ContaBancaria;

            if (resposta.ToString().ToLower() == "s")
            {
                Console.WriteLine("Informe o valor do depósito inicial: R$ ");
                double depositoInicial = double.Parse(Console.ReadLine());

                ContaBancaria = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);

            }
            else
            {
                ContaBancaria = new ContaBancaria(numeroConta, nomeTitular);
            }



            ContaBancaria.ExibirDadosBancarios();

            Console.WriteLine("Digite o valor do depósito");
            double valorDeposito = double.Parse(Console.ReadLine());
            ContaBancaria.DepositoInicial(valorDeposito);


            ContaBancaria.ExibirDadosBancarios();
            


            
            Console.WriteLine($"Informe o valor do saque: R$  ");
            double valorSaque = double.Parse(Console.ReadLine());
            ContaBancaria.Saque(valorSaque);





        }
    }
}
