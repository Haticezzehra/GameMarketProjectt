using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Hatice" && gamer.LastName == "Orhan" && gamer.IdentityNumber == 1111)
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
