﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    interface ITerroristFactory
    {
        Terrorist CreateTerrorist(int type);
    }
}
