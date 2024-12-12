using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        /*  1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
         *  - A placa deve ter 7 caracteres alfanuméricos;
         *  - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
         *  - Os quatro últimos caracteres são números;
         *  Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
        */

        Console.WriteLine("Digite a placa do veículo: ");
        var placa = Console.ReadLine().Replace(" ", "").ToUpper(); 

        string padrao = @"^[A-Z]{3}[0-9]{4}$";

        bool placaValida = Regex.IsMatch(placa, padrao);

        if (placaValida)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }

    }
}