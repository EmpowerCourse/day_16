using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ListExample();
            DictionaryExample();

            Console.ReadKey();
        }

        static void ListExample()
        {
            var list = new List<Pet>();
            list.Add(new Pet()
            {
                Name = "Jeff",
                Age = 13,
                IsSpotted = true,
                Color = "Black and White"
            });
            list.Add(new Pet()
            {
                Name = "Loretta",
                Age = 3,
                IsSpotted = false,
                Color = "Brown"
            });
            foreach (var pet in list)
            {
                if (pet.Name == "Loretta")
                {
                    Console.WriteLine("Found " + pet.Name + "!  Her age is:" + pet.Age.ToString());
                }
            }
        }

        static void DictionaryExample()
        {

            var dictionary2 = new Dictionary<string, Dictionary<int, Pet>>();

            var pet = new Pet()
            {
                Name = "Tika",
                Age = 1,
                IsSpotted = true,
                Color = "Black and White"
            };

            var nestedDictionary = new Dictionary<int, Pet>()
            {
                { pet.Age, pet },
                { 17, new Pet() }
            };
            dictionary2.Add(pet.Name, nestedDictionary);

            var tika = dictionary2["Tika"][1];

            ////////////////////////////////////////////////

            var dictionary = new Dictionary<string, Pet>();

            dictionary.Add("Jeff", new Pet()
            {
                Name = "Jeff",
                Age = 13,
                IsSpotted = true,
                Color = "Black and White"
            });
            dictionary.Add("Loretta", new Pet()
            {
                Name = "Loretta",
                Age = 3,
                IsSpotted = false,
                Color = "Brown"
            });

            dictionary.Add("Loretta", new Pet());

            var loretta = dictionary["Loretta"];
            Console.WriteLine("Found " + loretta.Name + "!  Age:" + loretta.Age.ToString());

        }
    }
}
