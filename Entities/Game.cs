using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Entities
{
    public class Game:IEntities
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
}
