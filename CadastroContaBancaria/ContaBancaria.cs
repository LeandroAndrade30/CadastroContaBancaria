using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroContaBancaria
{
    class ContaBancaria
    {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldo;

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial = 0.0)
        {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
            _saldo = depositoInicial;

        }

        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }
        }

        public string NomeTitular
        {
            get
            {
                return _nomeTitular;
            }


            set
            {
                _nomeTitular = value;
            }
        }


        public double Saldo
        {
            get
            {
                return _saldo;
            }
        }

        public void DepositoInicial(double valor)
        {

            _saldo = _saldo + valor;

            Console.WriteLine($"\n Depósito de R$ {valor} Realizado com sucesso!");
        }

        public void Saque(double valor)
        {
            if (_saldo >= valor)
            {
                _saldo = _saldo - valor;
                _saldo = _saldo - 5;

                Console.WriteLine($"\n Saque de R$ {valor} Realizado com sucesso! Seu saldo atual é de R$ {_saldo}");
            }
            else
            {
                Console.WriteLine("Seu saldo é insuficiente para realizar o saque.");
            }
        }

        public void ExibirDadosBancarios()
        {
            Console.WriteLine("\n Dados da Conta: ");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Nome do Titular: {NomeTitular}");
            Console.WriteLine($"Saldo $ {Saldo.ToString("F2")}");
        }


    }
}
