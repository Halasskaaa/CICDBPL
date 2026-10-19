namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            throw new System.Diagnostics.UnreachableException();
        }
    }
}
