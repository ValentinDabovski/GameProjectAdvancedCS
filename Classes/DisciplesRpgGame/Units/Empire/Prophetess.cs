﻿using DisciplesRpgGame.Enums;

namespace DisciplesRpgGame.Units.Empire
{
    public class Prophetess : Healer
    {
        private const int ProphetessExperience = 0;
        private const int ProphetessHealth = 125;
        private const Target ProphetessTarget = Target.All;
        private const int ProphetessHealing = 70;

        public Prophetess() 
            : base(ProphetessExperience, ProphetessHealth, ProphetessTarget, ProphetessHealing)
        {
        }
    }
}