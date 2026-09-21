namespace Ucu.Poo.RideShare
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public double Calificacion { get; set; }

        public Usuario(string nombre, string apellido, string cedula, double calificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Calificacion = calificacion;
        }
    }
}