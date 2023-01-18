using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName +" adlı oyuna "+campaign.DiscountRate+" oranında kampanya uygulandı.");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyundan " + campaign.DiscountRate + " oranında kampanya kaldırıldı.");
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyunun " + campaign.DiscountRate + " kampanyası güncellendi");
        }
    }
}
