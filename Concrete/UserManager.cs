using GameBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Concrete
{
    public class UserManager : IUserService

    {
        public void Delete(User user)
        {
            Console.WriteLine($"{user.Id} numaralı oyuncu silindi");
        }

        public void Save(User user)
        {
            Console.WriteLine($"{user.FirstName} has been saved successfully");
        }

        public void Update(User user)
        {
            Console.WriteLine($"{user.FirstName} updated!");
        }
    }
}
