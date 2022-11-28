using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
    public interface IGameService
    {
        void Sell(User user,Game game);
    }
}
