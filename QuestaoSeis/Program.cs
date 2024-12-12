using System.Globalization;

class Program
{
    static void Main()
    {
        /* 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
         * - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
         * - Apenas a data no formato "01/03/2024".
         * - Apenas a hora no formato de 24 horas.
         * - A data com o mês por extenso.
        */

        Console.WriteLine("Menu de Opcoes: \n" +
                          "1 - Formato Completo \n" +
                          "2 - Formato(dd/MM/yyyy) \n" +
                          "3 - Apenas a hora no formato de 24 horas \n" +
                          "4 - A data com o mês por extenso \n" +
                          "5 - Sair");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                FormatarCompleto();
                break;
            case 2:
                FormatarDiaMesAno();
                break;
            case 3:
                FormatarHoras();
                break;
            case 4:
                FormatarMesPorExtenso();
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Opcao invalida!");
                break;
        }
    }

    static void FormatarCompleto()
    {
        DateTime dataAtual = DateTime.UtcNow;
        string dataFormatada = dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine("Formato Completo: " + dataFormatada);
    }

    static void FormatarDiaMesAno()
    {
        DateTime dataAtual = DateTime.UtcNow;
        string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine("Formato (dd/MM/yyyy): " + dataFormatada);
    }

    static void FormatarHoras()
    {
        DateTime dataAtual = DateTime.UtcNow;
        string horaFormatada = dataAtual.ToString("HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine("Hora no formato 24h: " + horaFormatada);
    }

    static void FormatarMesPorExtenso()
    {
        DateTime dataAtual = DateTime.UtcNow;
        string mesFormatado = dataAtual.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine("Mês por extenso: " + mesFormatado);
    }
}
