using System;

namespace p1
{
    class Plant
    {
        public string Name { get; set; }

        public Plant(string name)
        {
            Name = name;
        }

        ~Plant()
        {
            Name = string.Empty;
        }

        public override string ToString()
        {
            return $"Plant: {Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plant[] plants = new Plant[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter plant {i + 1} name: ");
                string name = Console.ReadLine();
                plants[i] = new Plant(name);
            }

            Console.WriteLine("List of plants:");
            foreach (Plant plant in plants)
            {
                Console.WriteLine(plant.ToString());
            }
        }
    }
}
