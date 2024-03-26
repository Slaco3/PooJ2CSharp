// See https://aka.ms/new-console-template for more information
using PooJ2CSharp;

public class Program
{
    static void Main(string[] args)
    {
        Animal dragon = new Dragon();
        Animal griffin = new Griffin("Griffon");


        dragon.Moove();
        //griffin.Moove();
        //dragon.Sleep();

        //Console.WriteLine("\n");
        //Console.WriteLine(dragon.Name);
    }
}
