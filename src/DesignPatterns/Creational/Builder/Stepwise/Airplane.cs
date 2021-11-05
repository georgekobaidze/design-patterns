﻿namespace DesignPatterns.Creational.Builder.Stepwise
{
    public class Airplane
    {
        public AirplaneType Type { get; set; }
        public int SeatsCount { get; set; }

        public override string ToString()
        {
            return $"Airplane type: {Type.ToString()}\nSeats count: {SeatsCount}";
        }
    }
}
