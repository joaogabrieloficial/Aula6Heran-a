using System;

namespace Aula6Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "JOAO";
            cpf.cpf = "429568265-63";
             System.Console.WriteLine( cpf.Saudar() );
             System.Console.WriteLine(cpf.ValidarCPF() );


            CNPJ cnpj = new CNPJ();
            cnpj.nome ="gabriel";
            cnpj.cnpj ="00000000";
            System.Console.WriteLine(cnpj.Saudar() );
            System.Console.WriteLine(cnpj.ValidarCNPJ() );
         
        }
    }
}
