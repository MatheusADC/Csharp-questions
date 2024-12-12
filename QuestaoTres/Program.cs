class Program
{
    static void Main()
    {
        /* 1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
         *  - A soma entre esses dois números;
         *  - A subtração entre os dois números;
         *  - A multiplicação entre os dois números;
         *  - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
         *  - A média entre os dois números.
         *  Você pode ir além e permitir que o usuário insira dois números aleatórios! 
        */

        Console.WriteLine("Digite o primeiro número decimal: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo número decimal: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"SOMA: {numero1 + numero2}");
        Console.WriteLine($"SUBTRACAO: {numero1 - numero2}");
        Console.WriteLine($"MULTIPLICACAO: {numero1 * numero2}");

        if (numero2 == 0) {
            Console.WriteLine("Nao existe divisao por 0!");
        } else
        {
            Console.WriteLine($"DIVISAO: {numero1 / numero2}");
        }

        Console.WriteLine($"MEDIA: {(numero1 + numero2) / 2}");
    }
}