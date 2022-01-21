using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";

            Console.WriteLine(conta.titular);
            //campos de string sem valor definido recebe o valor vazio.
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.saldo);
            //campos de numeros sem valores definidos recebem o valor padrão de 0.


            Console.ReadLine();


        }
    }
}
