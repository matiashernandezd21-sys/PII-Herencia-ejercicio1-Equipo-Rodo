namespace Ucu.Poo.RideShare
{
    public class RegularDriver : Driver
    {
        public RegularDriver(string name, string lastName, string cedula, Car car, string bio, double rating) 
            : base(name, lastName, cedula, car, bio, rating)
        {
        }

        // Método para aceptar viajes regulares
        public bool AcceptRide(Passenger passenger)
        {
            // Lógica para aceptar viaje de un pasajero
            return true;
        }
    }
}