using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.048-39");
            roberta.Nome = "roberta";

            Auxiliar igor = new Auxiliar("981.222.656-39");
            igor.Nome = "igor";

            GerenteDeConta camila = new GerenteDeConta("253.842.963-39");
            camila.Nome = "camila";

            Desenvolvedor guilherme = new Desenvolvedor("285.584.963-39");
            camila.Nome = "guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);


            Console.WriteLine("Total de bonificacoes: " + 
                gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}