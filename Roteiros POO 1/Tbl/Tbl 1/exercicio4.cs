class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string num = Console.ReadLine();

        int resultado;

        if(int.TryParse(num, out resultado))
        {
            Console.WriteLine($"Número digitado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }
}
