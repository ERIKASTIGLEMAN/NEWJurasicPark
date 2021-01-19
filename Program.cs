using System;
using System.Collections.Generic;

namespace NEWJurasicPark
{
    //       Create a class to represent your dinosaurs. The class should have the following properties
    class Dino
    {

        public string Name { get; set; }
        //  Name - String


        public string DietType { get; set; }
        //  DietType - String - This will be "carnivore" or "herbivore"

        public DateTime WhenAcquired { get; set; }
        //  WhenAcquired - Date - This will default to the current time when the dinosaur is created
        // DateTime currentDateTime = DateTime.Now;

        public int Weight { get; set; }
        //  Weight - Int - How heavy the dinosaur is in pounds.

        public string EnclosureNumber { get; set; }
        //  EnclosureNumber - String - the number of the pen the dinosaur is in

        public String Description()
        {
            var dinoDescription = ($"The {Name}, as of {WhenAcquired}, lives in {EnclosureNumber}. With a {DietType} diet, this dinosaur weighs in at {Weight} whopping pounds!");
            return dinoDescription;

        }
        //  Add a method Description to your class to 

        // Console.WriteLine(dinoDescription);

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

            var dinosaurs = new List<Dino>()
            {
              new Dino()
              {
                  Name = "Brachio",
                  DietType = "Herbivore",
                  WhenAcquired = DateTime.Now,
                  Weight = 5000,
                  EnclosureNumber = "1H",
              },
               new Dino()
              {
                  Name = "T-Rex",
                  DietType = "Carnivore",
                  WhenAcquired = DateTime.Now,
                  Weight = 8000,
                  EnclosureNumber = "2C",
              },
               new Dino()
              {
                  Name = "Triceratops",
                  DietType = "Herbivore",
                  WhenAcquired = DateTime.Now,
                  Weight = 4000,
                  EnclosureNumber = "1A",
              },
            };
            //  Keep track of your dinosaurs in a List<Dinosaur>.






            //  When the console application runs, it should let the user choose one of the following actions:

            // While the user hasn't chosen to QUIT
            var chooseQuit = false;

            while (chooseQuit == false)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("VIEW - Show all Dinosaurs");
                Console.WriteLine("ADD - Add new Dinosaur");
                Console.WriteLine("REMOVE - Take Dinosaur out");
                Console.WriteLine("TRANSFER - Move Dinosaur's enclosure assignment");
                Console.WriteLine("SUMMARY - Shows number of carnivores and herbivores");
                Console.WriteLine("QUIT - Close Application");
                Console.WriteLine();
                Console.WriteLine("What would you like to see?");
                var option = Console.ReadLine().ToUpper();

                if (option == "VIEW")
                {

                }

                if (option == "ADD")
                {

                }

                if (option == "Remove")
                {

                }

                if (option == "TRANSFER")
                {

                }

                if (option == "SUMMARY")
                {

                }

                if (option == "QUIT")
                {
                    chooseQuit = true;
                }
            }
            // CHECK YOUR WORK
            // Console.WriteLine(option);


            // Display Menu:
            //  View  -  show the all dinosaurs in the list, 
            //       ordered by WhenAcquired Refer back to dateTime. 
            //       NO dinosaurs in the park then print out a message  THERE AREN'T ANY

            // Add  -  Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.

            // Remove  -  prompt the user for a dinosaur name then find and delete the dinosaur with that name.

            // Transfer  -  prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
            // Summary  -  display the number of carnivores and the number of herbivores.
            // Quit  -  End Program








            DisplayMessage("Thank you for visiting Jurassic Park Zoo! Goodbye!");
        }
    }
};
