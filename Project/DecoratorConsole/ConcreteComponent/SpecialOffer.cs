using DecoratorConsole.Component;
using DecoratorConsole.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorConsole.ConcreteComponent
{
    public class SpecialOffer : VehicleDecorator
    {
        public SpecialOffer(IVehicle vehicle) : base(vehicle) { }

        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }

        public double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
    }
}
