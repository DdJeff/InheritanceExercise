using System;

namespace Inheritance
 {  
    
    public class Animal
    {

        public int age;
        public string name;
        public string speed;
        public string foodType;

    }


    class Bird : Animal
    {
        public bool isAbleToFly = true;
        public string featherColor;
        public int toeCount;
        public string sound;
    }
    class Reptile : Animal
    {
        public bool isVenomous;
        public string location;
        public int length;
        public string HissSound;
    }
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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird woodpeaker = new Bird();

            woodpeaker.name = "Woody";
            woodpeaker.age = 2;
            woodpeaker.featherColor = "red and white";
            woodpeaker.foodType = "worms";
            woodpeaker.isAbleToFly = true;
            woodpeaker.sound = "knock knock";
            woodpeaker.speed = "15 mph";
            woodpeaker.toeCount = 3;

            Console.WriteLine($"{woodpeaker.name} is a " +
                $"{woodpeaker.featherColor} woodpeaker who loves to eat " +
                $"{woodpeaker.foodType}. He is repondsible for that " +
                $"{woodpeaker.sound} noise you may hear in the mornings. He flys at {woodpeaker.speed} and is very agile because of his large {woodpeaker.toeCount} toed foot." +
                $" So do you think {woodpeaker.name} is able to fly? True or false? Well the answer is {woodpeaker.isAbleToFly}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             *
             */

            Reptile snake = new Reptile();

            Console.WriteLine($"Is it {snake.isVenomous = true} that {snake.name = "Cobra"}s are venomous? " +
                $"Some {snake.name}s can be {snake.length = 15} feet long with a top speep of {snake.speed = "5"} mph at the age of {snake.age = 1}. " +
                $"If you hear a {snake.HissSound = "hissssss"}ing sound and you are in {snake.location = "Alabama"}, run." +
                $"{snake.name}s may harm you, but the good news is that mostly eat {snake.foodType = "other snakes"}.");
        }
    }
}
