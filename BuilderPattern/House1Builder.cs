using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class House1Builder:IHouseBuilder
    {
        House house = new House();

        public void BuildDoor()
        {
            house.Door = 10;
        }

        public bool BuildGarage()
        {
            house.hasGarage = false;
            return house.hasGarage;
        }

        public void BuildRoom()
        {
            house.Room = 12;
        }

        public bool BuildStatue()
        {
            house.hasStatues= false;
            return house.hasStatues;
        }

        public bool BuildSwimPool()
        {
            house.hasSwimPool = false;
            return house.hasSwimPool;
        }

        public void BuildWindow()
        {
            house.Window = 11;
        }
        public House GetHouse()
        {
            return house;
        }
    }
}
