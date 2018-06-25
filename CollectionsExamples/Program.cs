using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListExample();
            //DictionaryExample();
            //QueueExample();
            StackExample();

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

        static void QueueExample()
        {
            //var jeff = new Pet() { Name = "Jeff" };
            //var loretta = new Pet() { Name = "Loretta" };
            //var tika = new Pet() { Name = "Tika" };

            //var queue = new Queue<Pet>();
            //queue.Enqueue(jeff);
            //queue.Enqueue(loretta);
            //queue.Enqueue(tika);

            var queue = new Queue<Pet>();
            for (var i = 0; i < 100; i++)
            {
                var newPet = new Pet()
                {
                    Name = "Pet" + i.ToString("00")
                };
                queue.Enqueue(newPet);
            }


            while (queue.Count > 0)
            {
                var pet = queue.Dequeue();
                Console.WriteLine(pet.Name);
            }

            //Console.WriteLine(queue.Dequeue().Name);
            //Console.WriteLine(queue.Dequeue().Name);
            //Console.WriteLine(queue.Dequeue().Name);

        }

        static void StackExample()
        {
            var jeff = new Pet() { Name = "Jeff" };
            var loretta = new Pet() { Name = "Loretta" };
            var tika = new Pet() { Name = "Tika" };

            var stack = new Stack<Pet>();
            stack.Push(jeff);
            stack.Push(loretta);
            stack.Push(tika);

            while (stack.Count > 0)
            {
                var pet = stack.Pop();
                Console.WriteLine(pet.Name);
            }
        }
    }
}
