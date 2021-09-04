using System;

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

//Pensar numa solução para realizar uma operação com mais de 2 numeros
//Exemplo 2+3+9= ou 2+6+3+2 e assim vai
//Informe x numero que deseja somar, depois informe quais os numeros e some todos e apresente resultado

    }
}

