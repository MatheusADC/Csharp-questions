class Program
{
    static void Main()
    {
        /* Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
         * Você pode fazer uma verificação e incrementar o contador apenas se for um caractere, ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.
        */

        Console.WriteLine("Digite uma ou mais palavras: ");
        string palavrasSemEspacos = Console.ReadLine().Replace(" ", "");
        int numeroCarateres = palavrasSemEspacos.Length;
        Console.WriteLine("Quantidade de Caracteres: " + numeroCarateres);
    }
}