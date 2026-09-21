using System;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.RideShare
{
    public class Driver
    {
        public Car Car { get; set; }
        public String Bio { get; set; }

        public Driver (Car car, string bio)
        {
            Car = car;
            
            Bio = bio;
        }
    }
}