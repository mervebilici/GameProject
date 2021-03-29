using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Id==23 && gamer.FirstName=="MERVE" && gamer.LastName=="BİLİCİ" && gamer.IdentityNumber == 12345 && gamer.BirthYear==1999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Validate(object gamer)
        {
            throw new NotImplementedException();
        }
    }
}
