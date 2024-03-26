// See https://aka.ms/new-console-template for more information
using PooJ2CSharp;

public class Program
{
    static void Main(string[] args)
    {
        Dragon dragon = new Dragon();
        Griffin griffin = new Griffin("Griffon");

        Vehicle vehicle = new Vehicle();


        vehicle.Moove2();

        dragon.Moove();
        dragon.Moove2();
        
        Console.WriteLine(griffin.Name);


        //griffin.Moove();
        //dragon.Sleep();

        //Console.WriteLine("\n");
        //Console.WriteLine(dragon.Name);
    }
}
