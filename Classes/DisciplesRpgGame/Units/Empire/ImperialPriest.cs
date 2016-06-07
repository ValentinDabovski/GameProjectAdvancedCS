﻿using DisciplesRpgGame.Enums;

namespace DisciplesRpgGame.Units.Empire
{
    public class ImperialPriest : Healer
    {
        private const int ImperialPriestExperience = 0;
        private const int ImperialPriestHealth = 100;
        private const Target ImperialPriestTarget = Target.Anyone;
        private const int ImperialPriestHealing = 80;

        public ImperialPriest() 
            : base(ImperialPriestExperience, ImperialPriestHealth, ImperialPriestTarget, ImperialPriestHealing)
        {
        }
    }
}