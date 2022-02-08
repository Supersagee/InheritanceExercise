using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var zoo = new Zoo();
            
            var pigeon = new Bird("Pigeon", "White and Grey", true, 13, "Europe", "grains and fruits", 6, false);
            zoo.Birds.Add(pigeon);

            var chicken = new Bird("Chicken", "White and Red", false, 20, "Southeast Asia", "feed", 8, true);
            zoo.Birds.Add(chicken);

            var chameleon = new Reptile("Veiled Chameleon", "Green", true, 20, "Yemen", "plants and bugs", 6, true);
            zoo.Reptiles.Add(chameleon);

            var snake = new Reptile("Rattlesnake", "Yellow", false, (8 * 12), "Americas", "mice and rats", 10, false);
            zoo.Reptiles.Add(snake);

            Console.WriteLine("----Details of the birds in the zoo----");
            foreach (var item in zoo.Birds)
            {
                Console.WriteLine($"{item.BirdName} --- {item.FeatherColors} --- Can fly? {item.CanFly} --- {item.WingSpanInches} --- {item.CountryofOrigin} --- {item.Diet} --- {item.LifeExpectancy} --- Domesticated? {item.Domesticated}");
            }

            Console.WriteLine("----------------------------");

            Console.WriteLine("----Details of the reptiles in the zoo----");
            foreach (var item in zoo.Reptiles)
            {
                Console.WriteLine($"{item.ReptileName} --- {item.ScaleColors} --- Has legs? {item.HasLegs} --- {item.LengthInches} --- {item.CountryofOrigin} --- {item.Diet} --- {item.LifeExpectancy} --- Domesticated? {item.Domesticated}");
            }

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
