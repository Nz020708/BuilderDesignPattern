using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HouseBuilderDirector
    {
        private IHouseBuilder _housebuilder { get; set; }
        public HouseBuilderDirector(IHouseBuilder housebuilderr)
        {
            _housebuilder = housebuilderr;
        }
        public void BuildHouse()
        {
            _housebuilder.BuildRoom();
            _housebuilder.BuildWindow();
            _housebuilder.BuildDoor();
            _housebuilder.BuildGarage();
            _housebuilder.BuildStatue();
            _housebuilder.BuildSwimPool();
            
        }
        public House GetHouse()
        {
            return _housebuilder.GetHouse();
        }
    }
}
