using System.Collections.Generic;

namespace Ucu.Poo.RideShare
{
    public class PoolDriver : Driver
    {
        public int MaxPassengers { get; set; }
        public List<Passenger> Passengers { get; private set; }

        public PoolDriver(string name, string lastName, string id, Car car, string bio, double rating, int maxPassengers) 
            : base(name, lastName, id, car, bio, rating)
        {
            this.MaxPassengers = maxPassengers;
            this.Passengers = new List<Passenger>();
        }

        public bool AddPassenger(Passenger passenger)
        {
            if (this.Passengers.Count < this.MaxPassengers)
            {
                this.Passengers.Add(passenger);
                return true;
            }
            return false; // Capacidad máxima alcanzada
        }

        public bool RemovePassenger(Passenger passenger)
        {
            return this.Passengers.Remove(passenger);
        }
    }
}