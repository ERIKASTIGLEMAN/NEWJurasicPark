using System;
using System.Collections.Generic;
using System.Linq;

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
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            var userInputAsNumber = int.Parse(userInput);
            return userInputAsNumber;
        }
        static Dinosaurs PromptFindDinosaur(List<Dino> listOfSearchedDino)
        {
            var dinoName = PromptForString("What is the Name of the Dinosaur you want to locate? ");
            var dinoFound = listOfSearchedDino.Find(dinosaurs => dinosaurs.Name == dinoName);
            return dinoFound;
        }
        static string PromptForDescription(string dinoProperties)
        {
            Console.Write(dinoProperties);
            var userInput = Console.ReadLine();
            return userInput;
        }
        static void DisplayMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
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
                {var dinosaursInOrder = dinosaurs.OrderBy(dinosaurs => dinosaurs.WhenAcquired);
                    foreach (var dinosaur in dinosaursInOrder)
                    {
                        Console.WriteLine($"{dinoDescription}");
                    }

                    if (dinosaurs.Count == 0)
                    {
                        Console.WriteLine("We do not have any dinosaurs in our park at this time");
                    }

                }
                 if (option == "VIEW BY DATE")
                {
                    var dateSearched = DateTime.Parse(PromptForString("What date are you interested in searching? "));
                    var searchedDate = dinosaurs.Where(dinosaurs => dinosaurs.WhenAcquired >= dateSearched);
                    foreach (var dinosaur in searchedDate)
                    {
                        Console.WriteLine($"{dinosaur.Name} was received on {dateSearched} or after.");
                    }

                }

                if (option == "VIEW BY ENCLOSURE")
                {
                    var searchedEnclosureNumber = PromptForInteger("What enclosure number would you like to search for in out list? ");
                    var dinoFound = dinosaurs.Where(dinosaurs => dinosaurs.EnclosureNumber == searchedEnclosureNumber);
                    foreach (var dinosaur in dinoFound)
                    {
                        Console.WriteLine($"These Dinosaur-s {dinosaur.Name} were found in enclosure number {searchedEnclosureNumber}");
                    }
                }

                if (option == "ADD")
                {
                    var newDinoName = PromptForString("New Dinosaur's name?");
                    var newDinoDietType = PromptForString("New Dinosaur's Diet?");
                    var newDinoWeight = PromptForInteger("New Dinosaur's weight?");
                    var newDinoEnclosureNumber = PromptForInteger("New Dinosaur's enclosure number? ");

                    var newDino = new Dino()
                    {
                        Name = newDinoName,
                        DietType = newDinoDietType,
                        Weight = newDinoWeight,
                        EnclosureNumber = newDinoEnclosureNumber,
                        WhenAcquired = DateTime.Today,
                    };
                    dinosaurs.Add(newDino);
                }

                if (option == "Remove")
                {
                    var dinoFound = PromptFindDinosaur(dinosaurs);
                    dinosaurs.Remove(dinoFound);
                }

                if (option == "TRANSFER")
                {
                    var dinoFound = PromptFindDinosaur(dinosaurs);
                    Console.Write($"Transfer {dinoFound.Name} today? What number enclosure would you like to transfer him/her to? ");

                    var newEnclosureNumber = int.Parse(Console.ReadLine());
                    dinoFound.EnclosureNumber = newEnclosureNumber;
                    Console.WriteLine($"{dinoFound.Name} now lives in {dinoFound.EnclosureNumber}");
                }

                if (option == "SUMMARY")
                {
                     var numberOfCarnivores = dinosaurs.Count(dinosaurs => dinosaurs.DietType == "Carnivore");
                    Console.WriteLine($"Our total of Carnivores in the Park today is {numberOfCarnivores}");

                    var numberOfHerbivores = dinosaurs.Count(dinosaurs => dinosaurs.DietType == "Herbivore");
                    Console.WriteLine($"The total number of  Herbivores in the Park today is {numberOfHerbivores}");
                }

                if (option == "QUIT")
                {
                    chooseQuit = true;
                }
            }
            DisplayMessage("Thank you for visiting Jurassic Park Zoo! Goodbye!");
        }
    }
};
