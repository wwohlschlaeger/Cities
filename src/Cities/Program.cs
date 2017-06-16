using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
	public class Program
	{
		public static void Main(string[] args)
		{
			
				List<City> cities = CityDataImporter.LoadData();
				IComparer<City> comparerName = new NameComparer();
				IComparer<City> comparerState = new StateComparer();
				IComparer<City> comparerArea = new AreaComparer();
				IComparer<City> comparerPopulation = new PopulationComparer();
			// TODO Swap out comparers as desired
			string choice;
			do
			{
				Console.WriteLine("Sort by (A)rea, (N)ame, (P)opulation, or (S)tate");
				choice = Console.ReadLine().ToLower();
			
				if (choice == "n" || choice == "name")
					cities.Sort(comparerName);
				else if (choice == "a" || choice == "area")
					cities.Sort(comparerArea);
				else if (choice == "s" || choice == "state")
					cities.Sort(comparerState);
				else
					cities.Sort(comparerPopulation);



				PrintCities(cities);

				Console.ReadLine();
			} while (choice != "");
		}

		private static void PrintCities(List<City> cities)
		{
			Console.WriteLine(City.GetTableHeader());

			foreach (var city in cities)
			{
				Console.WriteLine(city);
			}

		}
    }
}
