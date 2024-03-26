// See https://aka.ms/new-console-template for more information
using PooJ2CSharp;




public class Program
{
    static void Main(string[] args)
    {   
        // monDragon IMPLEMENTE L'INTERFACE PILOTAGE et hérite de Animal
        Vehicle vehicle = new Vehicle();
        vehicle.Moove2();
        
        Dragon monDragon = new Dragon();
        monDragon.Moove2();
        monDragon.Moove();


        // CREATION LISTE ANIMAUX
        IList<Animal> animals = new List<Animal>();

        Dog dog1 = new Dog("Médor", Rarety.rare, 1);
        Dog dog2 = new Dog("Chien-Chien", Rarety.common, 2);
        Dog dog3 = new Dog("Régina", Rarety.rare, 3);
        Dog dog4 = new Dog("Snow", Rarety.common, 4);
        Dog dog5 = new Dog("Plutot", Rarety.rare, 5);
        Dragon dragon1 = new Dragon("PArturnax", Rarety.rare, 6);
        Dragon dragon2 = new Dragon();

        animals.Add(dog1);
        animals.Add(dog2);
        animals.Add(dog3);
        animals.Add(dog4);
        animals.Add(dog5);
        animals.Add(dragon1);
        animals.Add(dragon2);


        // LISTE ANIMAUX DE BASE
        IEnumerable<Animal> myAnimals =
            from animal in animals
            where animal.Name != "Snow"
            select animal;

        Console.WriteLine("\nLISTE DES CHIENS :");
        foreach (Animal myAnimal in myAnimals)
        {
            Console.WriteLine(" - " + myAnimal.Name);
        }


        // LISTE ANIMAUX RARES
        IEnumerable<Animal> myRareAnimals = animals.Where(dog => dog.Rarety == Rarety.rare);

        Console.WriteLine("\nLISTES DES ANIMAUX RARES : ");
        foreach(Animal myRareanimal in myRareAnimals)
        {
            Console.WriteLine(" - " + myRareanimal.Id + " : "+ myRareanimal.Name);
        }


        // LISTE ANIMAUX COMMUNS
        IEnumerable<Animal> myCommonAnimals = from animal in animals
                                           where animal.Rarety == Rarety.common
                                           orderby animal.Name
                                           select animal;

        Console.WriteLine("\nLITES DES ANIMAUX COMMUNS : ");
        foreach (Animal myCommonAnimal in myCommonAnimals)
        {
            Console.WriteLine(myCommonAnimal.Name + " rareté : " + myCommonAnimal.Rarety);
        }
    }
}
