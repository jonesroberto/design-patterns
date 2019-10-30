using BuilderConsole.Interfaces;

namespace BuilderConsole
{
    public class HouseDirector
    {
        private IHouseBuilder _houseBuilder;

        public IHouseBuilder HouseBuilder
        {
            set { _houseBuilder = value; }
        }

        public void BuildHouse()
        {
            _houseBuilder.BuildDoors();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildWindows();
        }

        public void BuildHouseFull()
        {
            _houseBuilder.BuildDoors();
            _houseBuilder.BuildRoof();
            _houseBuilder.BuildWalls();
            _houseBuilder.BuildWindows();
            _houseBuilder.BuildGarage();
        }
    }
}
