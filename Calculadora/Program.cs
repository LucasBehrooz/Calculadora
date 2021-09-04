namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Executar.Opcoes();
        }
    }
}




/* Primeira Calc
             int resultado;
            Console.WriteLine("====================CALCULADORA DO LUCÃO====================\n\n");
            Console.Write("Entre com o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("Calculo: {0} + {1} = {2}", num1, num2, resultado);
 */
/* Segunda Calc
            int numero1 = 0;
            int numero2 = 0;
            int result = 0;

            Console.WriteLine("====================CALCULADORA DO LUCÃO====================\n\n");

            Console.Write("Entre com o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual Operação deseja realizar? \n");
            Console.WriteLine("    1 - Soma");
            Console.WriteLine("    2 - Subtração");
            Console.WriteLine("    3 - Multiplicação");
            Console.WriteLine("    4 - Divisão");
            Console.Write("\nDigite a opção desejada: ");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Calculo: " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                    break;
                case "2":
                    var subtracao = numero1 - numero2;
                    Console.WriteLine("Calculo: {0} - {1} = {2}", numero1, numero2, subtracao);
                    break;
                case "3":
                    var multiplicacao = numero1 * numero2;
                    Console.WriteLine("Calculo: {0} * {1} = {2}", numero1, numero2, multiplicacao);
                    break;
                case "4":
                    var divisao = numero1 / numero2;
                    Console.WriteLine("Calculo: {0} / {1} = {2}", numero1, numero2, divisao);
                    break;
                default:
                    Console.WriteLine("Algo deu ruim");
                    break;
 */
