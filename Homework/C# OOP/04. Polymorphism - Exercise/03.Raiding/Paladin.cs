﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name)
          : base(name)
        {

        }

        public override int Power { get => base.Power + 100; }
        public override string CastAbility()
        {
            return $"Paladin - {Name} healed for {Power}";
        }
    }
}

