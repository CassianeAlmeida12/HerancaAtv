using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaEx
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }


        public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeInstituicao, int nConta, string agencia, string titular, double saldo)
            : base(nConta, agencia, titular, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
        }

        public override void Sacar(double valor)
        {
            //A operação de sacar nesse tipo de conta pode exceder o saldo em conta até o limite do cheque especial.

            if(valor > Saldo + LimiteChequeEspecial)
            {
                Console.WriteLine("Não é possível realizar o saque pois o saldo da conta é insuficiente");
            }
            else
            {
                Console.WriteLine($"Saque realizado com sucesso!");
            }
        }
    }
}
