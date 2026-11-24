namespace Ucu.Poo.RideShare
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cedula { get; set; }
        public double Rating { get; set; }
        public string image = @"../../../jane.jpg";

        public User(string name, string lastName, string cedula, double rating)
        {
            Name = name;
            LastName = lastName;
            Cedula = cedula;
            Rating = rating;
        }
    }
}