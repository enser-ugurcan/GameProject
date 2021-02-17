using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISales
    {
        void Sales(Game game, Gamer gamer);
        void Campaign(Game game, Gamer gamer, Campaign campaign);
        void ResultSales(Gamer gamer, Game game, Campaign campaign);
    }
}
