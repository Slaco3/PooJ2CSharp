// See https://aka.ms/new-console-template for more information
using PooJ2CSharp;

class Program
{
    static void Main(string[] args)
    {
        Animal animalRandom = new Animal();
        Animal animalLion = new Animal("Simba");


        Console.WriteLine(animalRandom.Name);
        animalRandom.Moove();
        animalLion.Moove();
    }
}
