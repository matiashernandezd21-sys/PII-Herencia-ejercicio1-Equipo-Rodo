namespace Ucu.Poo.RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User pasajero1 = new Passenger("Jose", "Perez", "12345678", "Tarjeta de crédito", 4.5);
            User pasajero2 = new Passenger("Maria", "Gomez", "87654321", "Efectivo", 4.0);
            User pasajero3 = new Passenger("Carlos", "Rodriguez", "11223344", "Transferencia bancaria", 4.8);
            Car carro1 = new Car("ABC123");
            User conductor1 = new Driver("Luis", "Martinez", "55667788", carro1, "Conductor confiable y seguro", 5.0);
            Car carro2 = new Car("XYZ789");
            User conductorPool1 = new PoolDriver("Ana", "Lopez", "99887766", carro2, "Conductor con experiencia en viajes compartidos", 4.7, 4);
            UcuRideShare rideShare = new UcuRideShare();

            rideShare.Add(conductor1);
            //Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1);
            //Se publica en Twitter un nuevo conductor!

            rideShare.Add(pasajero1);
            //Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero2);
            //Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3);
            //Se publica en Twitter nuevo registro de pasajero!

            
        }
    }
}
