// See https://aka.ms/new-console-template for more information
using PooJ2CSharp;

public class Program
{
    static void Main(string[] args)
    {
        //Dragon dragon = new Dragon();
        //Griffin griffin = new Griffin("Griffon");

        //Vehicle vehicle = new Vehicle();


        //vehicle.Moove2();

        //dragon.Moove();
        //dragon.Moove2();
        
        //Console.WriteLine(griffin.Name);


        IList<Dog> dogs = new List<Dog>();

        Dog dog1 = new Dog("Médor", "rare", 1);
        Dog dog2 = new Dog("Chien-Chien", "Commun", 2);
        Dog dog3 = new Dog("Régina", "Commun", 3);
        Dog dog4 = new Dog("Snow", "rare", 4);
        Dog dog5 = new Dog("Plutot", "rare", 5);

        dogs.Add(dog1);
        dogs.Add(dog2);
        dogs.Add(dog3);
        dogs.Add(dog4);
        dogs.Add(dog5);


        IEnumerable<Dog> myDogs =
            from dog in dogs
            where dog.Name != "Snow"
            select dog;

        Console.WriteLine("\nLISTE DES CHIENS :");
        foreach (Dog dog in myDogs)
        {
            Console.WriteLine(" - " + dog.Name);
        }


        IEnumerable<Dog> myRareAnimals = dogs.Where(dog => dog.Rarety == "rare");

        Console.WriteLine("LISTES DES ANIMAUX RARES : ");
        foreach(Dog dog in myRareAnimals)
        {
            Console.WriteLine(" - " + dog.Id + " : "+ dog.Name);
        }

        IEnumerable<Dog> myCommonAnimals = from dog in dogs
                                           where dog.Rarety == "Commun"
                                           orderby dog.Name
                                           select dog;


        Console.WriteLine("\nLITES DES ANIMAUX COMMUNS : ");
        foreach (Dog dog in myCommonAnimals)
        {
            Console.WriteLine(dog.Name);
        }

    }
}
