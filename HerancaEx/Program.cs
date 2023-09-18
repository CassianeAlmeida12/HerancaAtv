using System;
using HerancaEx;

public class Programa
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

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

                if(escolha == 1)
                {
                    Console.Write("Digite o número da conta: ");
                    c.NConta = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

