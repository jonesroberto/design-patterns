using BuilderConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderConsole
{
    public class HouseConcreteBuilder : IHouseBuilder
    {
        private HouseProduct _houseProduct = new HouseProduct();

        public HouseConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _houseProduct = new HouseProduct();
        }

        public void BuildDoors()
        {
            HousePart part = new HousePart
            {
                Name = "Door"
            };

            _houseProduct.Add(part);
        }

        public void BuildGarage()
        {
            HousePart part = new HousePart
            {
                Name = "Garage"
            };

            _houseProduct.Add(part);
        }

        public void BuildRoof()
        {
            HousePart part = new HousePart
            {
                Name = "Roof"
            };

            _houseProduct.Add(part);
        }

        public void BuildWalls()
        {
            HousePart part = new HousePart
            {
                Name = "Walls"
            };

            _houseProduct.Add(part);
        }

        public void BuildWindows()
        {
            HousePart part = new HousePart
            {
                Name = "Windows"
            };

            _houseProduct.Add(part);
        }

        public void BuildGarden()
        {
            HousePart part = new HousePart
            {
                Name = "Garden"
            };

            _houseProduct.Add(part);
        }

        public HouseProduct GetProduct()
        {
            HouseProduct result = _houseProduct;

            Reset();

            return result;
        }
    }
}
