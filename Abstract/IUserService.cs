using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);


    }
}
