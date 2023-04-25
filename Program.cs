internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Menu();

        Console.ReadKey();
    }

    static void Menu(){
        Console.WriteLine("Bem vinso! o que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");

        Console.WriteLine("--------------------------");
        Console.Write("Selecione uma opção: ");
        short opcao = short.Parse(Console.ReadLine());
    }

    static void Soma()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 + valor2;

        Console.WriteLine($"{valor1} + {valor2} = {resultado}");
    }

    static void Subtracao()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 - valor2;

        Console.WriteLine($"{valor1} + {valor2} = {resultado}");

    }

    static void Divisao()
    {
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 / valor2;

        Console.WriteLine($"{valor1} / {valor2} = {resultado}");
    }

    static void Multiplicacao(){
        Console.Write("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 * valor2;

        Console.WriteLine($"{valor1} * {valor2} = {resultado}");
    }

}