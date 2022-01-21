using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(87494968, 149);

            //conta.Numero = 87494968;
            //conta.Agencia = 149;


            Console.WriteLine("agencia 1:" + conta.Agencia);
            Console.WriteLine("conta 1:" + conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(423579048, 958);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    } 
}
