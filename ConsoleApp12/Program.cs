internal class Program
{
    private static void Main(string[] args)
    {
        byte bytex = 255;
        byte bytey = 1;
        int xnegative = -2147483647;
        int xnegative1 = xnegative / 2;
        uint x = 4294967295;
        Console.WriteLine(bytex);
        Console.WriteLine(bytex - bytey);
        Console.WriteLine(xnegative);
        Console.WriteLine(xnegative1);
        Console.WriteLine(x);
        Console.WriteLine("Salutare lume!");
        Console.WriteLine("Apasa   o cheie ca sa inchei programul ");
        Console.ReadKey ();
    }
}