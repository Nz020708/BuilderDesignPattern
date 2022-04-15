using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
   public  interface IHouseBuilder
    {
        void BuildWindow();
        void BuildDoor();
        void BuildRoom();
        bool BuildGarage();
        bool BuildSwimPool();
        bool BuildStatue();
        House GetHouse();
    }
}
