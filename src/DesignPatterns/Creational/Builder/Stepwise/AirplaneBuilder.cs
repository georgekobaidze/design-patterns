using DesignPatterns.Creational.Builder.Stepwise.Interfaces;
using System;

namespace DesignPatterns.Creational.Builder.Stepwise
{
    public class AirplaneBuilder
    {
        private class Impl : ISpecifyAirplaneType, ISpecifySeatsCount, IBuildAirplane
        {
            private Airplane _airplane = new Airplane();

            public Airplane Build() => _airplane;

            public ISpecifySeatsCount OfType(AirplaneType type)
            {
                _airplane.Type = type;
                return this;
            }

            public IBuildAirplane WithSeatsNumber(int count)
            {
                if (_airplane.Type == AirplaneType.Public && count < 50)
                    throw new ArgumentException("Seat count is invalid for this type of airplane!");

                _airplane.SeatsCount = count;
                return this;
            }
        }

        public static ISpecifyAirplaneType Create() => new Impl();
    }
}
