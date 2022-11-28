using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
    public interface IUserValidationService
    {
        public bool RealPersonValidation(User user);
    }
}
