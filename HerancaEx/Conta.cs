using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx
{
    internal class Conta
    {
        public int NConta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {

        }
        public Conta(int nConta, string agencia, string titular, double saldo)
        {
            NConta = nConta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;
        }



        //Verifica se há saldo suficiente
        public virtual void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"Saque realizado  com sucesso! \n Total de Saldo: {Saldo}");
            }

            else
            {
                Console.WriteLine("Não é possível realizar o saque pois o saldo da conta é insuficiente");
            }
        }

        public virtual void Depositar(double valor) 
        {
            Saldo += valor;
            Console.WriteLine($"Deposito realizado com sucesso! \n Total da conta: {Saldo}");
        }
    }
}
