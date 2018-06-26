using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
			//var numbers = new List<int>();
			//numbers.Add(1);
			//numbers.Add(2);
			//numbers.Add(3);
			//var sum = numbers.Sum();
			//Console.WriteLine(sum);

			//var sum = products.Sum(p => p.Price);

			//var max = products.Max(p => p.Price);
			//var min = products.Min(p => p.Price);
			//var avg = products.Average(p => p.Price);


			//var car = products.FirstOrDefault(p => p.Name == "Car");

			//if (car == null)
			//{
			//	// Do stuff
			//}

			var products = new List<Product>();
			products.Add(new Product() { Name = "MP3 Player", Price = 31.99m });
			products.Add(new Product() { Name = "Suitcase", Price = 22 });
			products.Add(new Product() { Name = "Car", Price = 3200 });

			var x = 31.99;

			//var car = products.SingleOrDefault(p => p.Name == "car");

			//var any = products.Any(p => p.Price > 0);

			//var all = products.All(p => p.Price > 0);

			//var numbers = new List<int>();
			//numbers.Add(1);
			//numbers.Add(2);
			//numbers.Add(3);
			//numbers.Add(3);
			//numbers.Add(3);

			//var distinct = numbers.Distinct();

			var sum = products
				.Where(p => p.Name != "Car")
				.Sum(p => p.Price);

			//var nonCars = products.Where(p => p.Name != "Car");
			//var sum2 = nonCars.Sum(p => p.Price);


			Console.ReadKey();
        }
    }
}
