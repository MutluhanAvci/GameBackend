using GameBackend.Abstract;
using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Concrete
{
    public class GameManager : IGameService
    {
        
        public void Sell(User user, Game game)
        {
            
            Dictionary<User, Game> userGames = new Dictionary<User, Game>();
            userGames.Add(user, game);

            Console.WriteLine($"{game.Name} added to {user.FirstName}'s library");
            
            foreach (KeyValuePair<User, Game> item in userGames)
            {
                Console.WriteLine(item.Key.FirstName + "----" + item.Value.Name);
            }
        }
    }



}
