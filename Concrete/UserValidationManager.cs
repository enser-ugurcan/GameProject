using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.Name == "Enser" && gamer.Surname == "Ateşçakmak" && gamer.BirthDay == 1998 && gamer.IndentityNumber == 222)
            {
                return true;
            }
            else if (gamer.Id == 2 && gamer.Name == "Uğurcan" && gamer.Surname == "Ateşçakmak" && gamer.BirthDay == 1998 && gamer.IndentityNumber == 333)
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
