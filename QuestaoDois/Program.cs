class Program
{
    static void Main()
    {
        // Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"{nome} {sobrenome}");
    }
}