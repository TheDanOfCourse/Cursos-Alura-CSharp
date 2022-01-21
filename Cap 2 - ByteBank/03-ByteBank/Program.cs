using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //saldo está com valor padrão de 100 definido na classe

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            //igualdade de tipo de referência
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            int idade = 27;
            int idadeMaisUmaVez = 27;
            //igualdade de tipo de valor
            Console.WriteLine(idade == idadeMaisUmaVez);


            //duas referências apontando para o mesmo lugar, então boolean = true
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);


            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);


            if (contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
