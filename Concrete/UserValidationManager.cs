using GameBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool RealPersonValidation(User user)
        {
            return true;
        }
    }
}
