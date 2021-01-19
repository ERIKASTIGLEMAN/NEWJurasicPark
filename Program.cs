using System;
using System.Collections.Generic;

namespace NEWJurasicPark
{
    //       Create a class to represent your dinosaurs. The class should have the following properties
    class Dino
    {
        //  Name - String
        public string Name { get; set; }
        //  DietType - String - This will be "carnivore" or "herbivore"
        public string DietType { get; set; }
        //  WhenAcquired - Date - This will default to the current time when the dinosaur is created
        public DateTime Date { get; set; }
        // DateTime currentDateTime = DateTime.Now;
        public int Weight { get; set; }
        //  Weight - Int - How heavy the dinosaur is in pounds.
        public string EnclosureNumber { get; set; }
        //  EnclosureNumber - String - the number of the pen the dinosaur is in

        public String Description()
        {
            var dinoDescription = ($"The {Name}, as of {Date}, lives in {EnclosureNumber}. With a {DietType} diet, this dinosaur weighs in at {Weight} whopping pounds!");
            return dinoDescription;

            //  Add a method Description to your class to 
        }

        Console.WriteLine(dinoDescription);

        // print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.
    }



    class Program
    {
        static void DisplayMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForDescription(string dinoProperties)
        {
            Console.Write(dinoProperties);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static void Main(string[] args)
        {
            DisplayMessage("Welcome to Jurassic Park Zoo");

            var dinosaurs = new List<Dino>(){
              new Dino()
              {

              }
            };
            //  Keep track of your dinosaurs in a List<Dinosaur>.


            //  When the console application runs, it should let the user choose one of the following actions:

            //  View
            // This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.
            //  Add
            // This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
            //  Remove
            // This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
            //  Transfer
            // This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
            //  Summary
            //  This command will display the number of carnivores and the number of herbivores.
            //  Quit
            //  This will stop the program


            DisplayMessage("Thank you for visiting Jurassic Park Zoo! Goodbye!");
        }
    }
}
