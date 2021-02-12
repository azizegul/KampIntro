using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, BirthYear = 1992, FirstName = "Azize ", LastName = "Aydoğdu", IdentityNumber = 11111 };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, BirthYear = 2020, FirstName = "Ece ", LastName = "Aydoğdu", IdentityNumber = 22222 };

            Game game1 = new Game() { Id = 2, GameName = "PUBG", GamePrice = 650 };
            Game game2 = new Game() { Id = 3, GameName = "FORTNİTE", GamePrice = 450 };
            Game game3 = new Game() { Id = 4, GameName = "GTA 5", GamePrice = 550 };


            Campaign campaign1 = new Campaign() { CampaignName = "YENİ ÜYE KAMPANYASI", CampaignEndDate = 052021, CampaignId = 1 };
            Campaign campaign2 = new Campaign() { CampaignName = "COVİD-19 KAMPANYASI", CampaignEndDate = 012021, CampaignId = 2 };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SaleManager salesManager = new SaleManager();
            salesManager.Sales(game3, gamer2);
            salesManager.CampaignSales(game2, gamer1, campaign2);
        }
    }
}
