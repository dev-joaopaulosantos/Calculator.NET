internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Menu();

    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Bem vinso! o que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("--------------------------");
        Console.Write("Selecione uma opção: ");

        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Divisao();
                break;
            case 4:
                Multiplicacao();
                break;
            case 0:
                System.Environment.Exit(0);
                break;
            default:
                Menu();
                break;
        }
    }

    static void Soma()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 + valor2;

        Console.WriteLine($"{valor1} + {valor2} = {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 - valor2;

        Console.WriteLine($"{valor1} + {valor2} = {resultado}");

        Console.ReadKey();
        Menu();

    }

    static void Divisao()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 / valor2;

        Console.WriteLine($"{valor1} / {valor2} = {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 * valor2;

        Console.WriteLine($"{valor1} * {valor2} = {resultado}");

        Console.ReadKey();
        Menu();
    }

}