﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketProjectt
{
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
