using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Tc == 222222220 && gamer.FirstName == "Azize" && gamer.LastName == "Aydoğdu" && gamer.BirthYear == 1992)
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
