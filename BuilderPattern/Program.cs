using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var house1builder = new HouseBuilderDirector((new House1Builder()));
            house1builder.BuildHouse();
            house1builder.GetHouse();
            var house = new House();
            house.Room = 11;
            Console.WriteLine($"Count of rooms:{house.Room}");
        }
    }
}
