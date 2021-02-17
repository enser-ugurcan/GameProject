using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {Name="Enser",Surname="Ateşçakmak",Id=1,IndentityNumber=222,BirthDay=1998 };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { Name = "Ugurcan", Surname = "Ateşçakmak", Id = 1, IndentityNumber = 333, BirthDay = 1998 };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            
          
            Game game = new Game() {GameId=1,GameName="NeedForSpeed",GamePrice=150 };
            Game game2 = new Game() { GameId = 2, GameName = "Counter Striker", GamePrice = 100 };
            

            Campaign campaign = new Campaign() {CampaignId=1,CampaignName=" Black Friday",Discount=20 };
            Campaign campaign2 = new Campaign() { CampaignId = 1, CampaignName = " Yeni üye ", Discount = 40 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Add(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game, gamer1);
            salesManager.Campaign(game, gamer1, campaign);
            salesManager.ResultSales(gamer, game2, campaign2);
            

        }
    }
}
