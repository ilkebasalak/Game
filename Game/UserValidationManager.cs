using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthDay==1994 && gamer.FirstName=="ilke" &&gamer.LastName=="Başalak" && gamer.ıdentityNumber==5678)
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
