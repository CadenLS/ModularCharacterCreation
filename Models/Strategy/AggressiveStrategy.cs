﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Models.Strategy
{
    public class AggressiveStrategy : IAttackStrategy
    {
        public string Execute() => "Attacks relentlessly!";
    }

}
