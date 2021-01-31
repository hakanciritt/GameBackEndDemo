using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEndDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.IdentityNumber!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
