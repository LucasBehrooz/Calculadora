using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Executar
    {
        public const int SOMA = 1;
        public const int SUBTRACAO = 2;
        public const int MULTIPLICACAO = 3;
        public const int DIVISAO = 4;
        public const int SAIR_PROGRAMA = 5;


        public static void Opcoes()
        {
            while (true)
            {
                var inicio = "\n====================CALCULADORA DO LUCÃO====================\n"
                    + "\nQual Operação deseja realizar?"
                    + "\n    1 -  Soma"
                    + "\n    2 -  Subtração"
                    + "\n    3 -  Multiplicação"
                    + "\n    4 -  Divisão"
                    + "\n    5 -  Sair do Programa";

                Console.WriteLine(inicio);
                Console.Write("Entre com a opção desejada: ");
                var escolha = int.Parse(Console.ReadLine());
                if (SOMA == escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=====Opção Soma=====");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número: ");
                    var numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    var numero2 = int.Parse(Console.ReadLine());
                    Operacoes.Soma(numero1, numero2);
                }
                else if (SUBTRACAO == escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=====Opção Subtração=====");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número: ");
                    var numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    var numero2 = int.Parse(Console.ReadLine());
                    Operacoes.Subtracao(numero1, numero2);
                }
                else if (MULTIPLICACAO == escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=====Opção Multiplicação=====");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número: ");
                    var numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    var numero2 = int.Parse(Console.ReadLine());
                    Operacoes.Multiplicacao(numero1, numero2);
                }
                else if (DIVISAO == escolha)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=====Opção Multiplicação=====");
                    Console.ResetColor();
                    Console.Write("Digite o primeiro número: ");
                    var numero1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    var numero2 = int.Parse(Console.ReadLine());
                    Operacoes.Divisao(numero1, numero2);
                }
                else if (SAIR_PROGRAMA == escolha)
                {
                    Console.WriteLine("Saindo do Programa!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nDigite uma opção Valida\n");
                }
            }
        }
    }
}
