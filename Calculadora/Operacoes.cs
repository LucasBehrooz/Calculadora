using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacoes
    {
        public static void Soma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;  
            
            Console.WriteLine("Calculo Soma: {0} + {1} = {2}", numero1,numero2,resultado);
        }

        public static void Subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;

            Console.WriteLine("Calculo Subtração: {0} - {1} = {2}", numero1, numero2, resultado);
        }

        public static void Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;

            Console.WriteLine("Calculo Multiplicação: {0} * {1} = {2}", numero1, numero2, resultado);
        }

        public static void Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;

            Console.WriteLine("Calculo Divisão: {0} / {1} = {2}", numero1, numero2, resultado);
        }


        //Fazer as outras 3 operações

    }
}
