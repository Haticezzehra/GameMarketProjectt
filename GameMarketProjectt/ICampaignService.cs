﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign,Game game);
        void Delete (Campaign campaign, Game game);    
        void Update(Campaign campaign, Game game);
    }
}
