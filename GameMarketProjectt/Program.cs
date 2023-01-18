using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                BirthYear = 2001,
                FirstName = "Hatice",
                LastName = "Orhan",
                IdentityNumber = 1111
            };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
           
            Game game = new Game();
            game.GameName = "Pubg";
            game.GamePrice = 10;
            game.Id = 1;

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "yıl sonu indirimi";
            campaign.DiscountRate = 10;
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign, game);


            OrderManager orderManager= new OrderManager();
            orderManager.Sell(gamer, game);
            

            Console.ReadKey();
        }
    }
}
