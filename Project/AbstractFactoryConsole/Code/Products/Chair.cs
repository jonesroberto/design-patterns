using AbstractFactoryConsole.Code.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.Code.Products
{
    public class Chair : IChair
    {
        ProductType _type;

        public Chair(ProductType type)
        {
            _type = type;
        }

        public string Get()
        {
            switch (_type)
            {
                case ProductType.Victorian:
                    return ProductType.Victorian.ToString();
                case ProductType.ArtDeco:
                    return ProductType.ArtDeco.ToString();
                case ProductType.Modern:
                    return ProductType.Modern.ToString();
            }

            return null;
        }
    }
}
