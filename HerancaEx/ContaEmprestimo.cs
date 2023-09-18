using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx
{
    internal class ContaEmprestimo:Conta
    {

        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmprestimo(double anuidade, double limiteEmprestimo, double totalEmprestimo, int nConta, string agencia, string titular, double saldo)
            : base(nConta, agencia, titular, saldo)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public virtual void FazerEmprestimo(double valor)
        {
            //receber um valor de empréstimo e verificar se o cliente possui limites para realizar tal empréstimo.
            if(valor <= LimiteEmprestimo)
            {
                LimiteEmprestimo -= valor;
                Console.WriteLine($"Emprestimo realizado com sucesso! \n Total do Limite Emprestimo: {LimiteEmprestimo} ");
            }
            else
            {
                Console.WriteLine("Limite de Emprestimo excedido!");
            }
        }

        public override void Sacar(double valor)
        {
            //a conta para empresa possui uma taxa para saques acima de R$ 5000,00 que é de R$ 5,00.
            if(valor > Saldo)
            {
                Console.WriteLine("Saldo indisponivel!");
            }
            else if(valor <= Saldo)
            {
                if(valor >= 5000)
                {
                    double taxa = 5.00;
                    Saldo = (valor + taxa) - Saldo;
                    Console.WriteLine($"Saque realizado com sucesso! \n Valor total da conta: {Saldo}");
                }

                Saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso! \n Valor total da conta: {Saldo}");
            }
        }
    }   
}
