using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGame
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " is Add");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is Delete");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " is Uptade");
        }
    }
}
