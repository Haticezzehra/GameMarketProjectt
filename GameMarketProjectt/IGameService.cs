﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
