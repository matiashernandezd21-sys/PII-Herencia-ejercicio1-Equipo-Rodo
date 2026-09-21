using System;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.RideShare
{
    public class Driver : User
    {
        public Car Car { get; set; }
        public String Bio { get; set; }

        public Driver (string name, string lastName, string cedula, Car car, string bio, double rating)
            : base (name, lastName, cedula, rating)
        {
            this.Car = car;
            this.Bio = bio;
        }
    }
}