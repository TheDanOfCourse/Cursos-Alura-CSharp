using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            Console.WriteLine("Saldo Bruno: " + contaDoBruno.saldo);


            contaDoBruno.Sacar(100);
            Console.WriteLine("Saldo após saque: " + contaDoBruno.saldo);


            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo do bruno após deposito: " + contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";


            contaDoBruno.Transferir(200, contaDaGabriela);
            
            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);


            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);

            Console.ReadLine();


        }
    }
}
