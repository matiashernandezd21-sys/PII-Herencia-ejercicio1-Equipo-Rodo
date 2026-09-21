namespace Ucu.Poo.RideShare
{
    public class RegularDriver : Driver
    {
        public RegularDriver(string name, string lastName, string id, Car car, string bio) 
            : base(name, lastName, id, car, bio)
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