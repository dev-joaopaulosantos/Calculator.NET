internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Soma();

        Console.ReadKey();
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

}