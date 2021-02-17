using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISales
    {
        public void Campaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.Name + " " + campaign.CampaignName + " kampayası ile " + game.GameName + " oyununu aldı ");
        }

        public void ResultSales(Gamer gamer, Game game, Campaign campaign)
        {
            int a = game.GamePrice;
            int b = campaign.Discount;
            int result;
            result = a - a * b / 100;
            Console.WriteLine(gamer.Name + " " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile " + result + " fiyata aldı ");

        }
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + game.GameName + " oyunu aldı");
        }

    }
}
