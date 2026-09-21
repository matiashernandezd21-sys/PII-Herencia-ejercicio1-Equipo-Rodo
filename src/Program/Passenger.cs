namespace Ucu.Poo.RideShare
{
    public class Passenger : User
    {
        public string PaymentMethod { get; set; }

        public Passenger(string name, string lastName, string cedula, string paymentMethod, double rating) 
            : base(name, lastName, cedula, rating)
        {
            this.PaymentMethod = paymentMethod;
        }

        public void RequestRide(string origin, string destination)
        {
            // Lógica para solicitar un viaje
        }
    }
}