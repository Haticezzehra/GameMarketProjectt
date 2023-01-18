using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal class OrderManager : IOrderService
    {
        public void Sell( Gamer gamer,Game game)
        {

            Console.WriteLine(game.GameName + "  adlı oyun " + gamer.FirstName+ " adlı oyuncuya satıldı");
        }
    }
}
