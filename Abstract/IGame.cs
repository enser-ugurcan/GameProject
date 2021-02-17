using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGame
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
