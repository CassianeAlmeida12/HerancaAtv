using System;
using HerancaEx;

public class Programa
{
    static void Main(string[] args)
    {
        Conta c = new Conta();
        ContaEstudante d = new ContaEstudante();


        while(true)
        {
            try
            {
                Console.WriteLine("1 - Conta");
                Console.WriteLine("2 - Conta Estudante");
                Console.WriteLine("3 - Conta Empresarial");
                Console.WriteLine("4 - Sair do programa");
                Console.Write("Escolha o tipo de conta bancária que você deseja criar: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                

                //CONTA NORMAL
                if(escolha == 1)
                {
                    Console.Write("Digite o número da conta: ");
                    c.NConta = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o nome da sua agência: ");
                    c.Agencia = Console.ReadLine();
                    Console.Write("Digite o nome do Titual da conta: ");
                    c.Titular = Console.ReadLine();
                    Console.Write("Digite o seu saldo atual: ");
                    c.Saldo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nQual das operação abaixo você gostaria de realizar? ");
                    Console.WriteLine("1 - Sacar");
                    Console.WriteLine("2 - Depositar");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());

                    if( escolha2 == 1)
                    {
                        Console.Write("\nDigite o valor que você quer sacar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Sacar(valor);
                    }
                    else if(escolha2 == 2)
                    {
                        Console.Write("\nDigite o valor que você quer depositar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                    }
                }



                //CONTA ESTUDANTE
                else if(escolha == 2)
                {
                    Console.Write("\nDigite o número da conta: ");
                    d.NConta = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite o nome da sua agência: ");
                    d.Agencia = Console.ReadLine();
                    Console.Write("Digite o nome do Titual da conta: ");
                    d.Titular = Console.ReadLine();
                    Console.Write("Digite o seu saldo atual: ");
                    d.Saldo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o seu cpf: ");
                    d.Cpf = Console.ReadLine();
                    Console.Write("Digite o nome da instituição do estudante: ");
                    d.NomeInstituicao = Console.ReadLine();
                    Console.Write("Digite o valor do seu limite cheque especial: ");
                    d.LimiteChequeEspecial = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

