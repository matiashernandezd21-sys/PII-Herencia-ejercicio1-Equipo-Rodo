using System.Collections.Generic;

namespace Ucu.Poo.RideShare
{
    public class UcuRideShare
    {
        private List<User> users;

        public UcuRideShare()
        {
            users = new List<User>();
        }

        public void Add(User user)
        {
            users.Add(user);
            // Lógica para publicar en Twitter el nuevo registro de usuario
        }

    }
}