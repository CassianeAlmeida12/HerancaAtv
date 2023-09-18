using System;
using HerancaEx;

public class Programa
{
    static void Main(string[] args)
    {
        //Conta c = new Conta(01, "caixa", "cassiane", 2000);
        //c.Sacar(100);

        //ContaEstudante c = new ContaEstudante(1000, "084.178.252-34", "ifro", 01, "caixa", "cassi", 1000);
        //c.Sacar(1000);

        ContaEmprestimo c = new ContaEmprestimo(10, 2000, 10, 01, "caixa", "cassi", 6000);
        c.FazerEmprestimo(3000);
    }
}

