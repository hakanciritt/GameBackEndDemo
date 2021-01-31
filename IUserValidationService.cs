using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEndDemo
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
