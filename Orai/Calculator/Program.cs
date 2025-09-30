internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello, World!");
        }
        catch (Exception ex)
        {
            // Pokémon exception handling
            Console.WriteLine(ex.Message);
        }
    }
}