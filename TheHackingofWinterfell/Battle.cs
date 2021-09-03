namespace TheHackingofWinterfell
{
    public class Battle
    {
        public Battle(Army sevenKingdomArmy, Army whiteWalkerArmy)
        {
            this.SevenKingdomArmy = sevenKingdomArmy;
            this.WhiteWalkerArmy = whiteWalkerArmy;
        }

        public Army SevenKingdomArmy { get; private set; }

        public Army WhiteWalkerArmy { get; private set; }

        public string WinnerArmyName { get; private set; }

        public int NumberOfAttacks { get; private set; }

        public void Fight(string nextArmyToStrike)
        {
            bool hasWinnerArmyName = string.IsNullOrWhiteSpace(this.WinnerArmyName);
            if(hasWinnerArmyName)
            {
                this.NumberOfAttacks++;

                if(nextArmyToStrike == this.SevenKingdomArmy.ArmyName)
                {
                    this.Attack(this.SevenKingdomArmy, this.WhiteWalkerArmy);
                    nextArmyToStrike = this.WhiteWalkerArmy.ArmyName;
                }
                else
                {
                    this.Attack(this.WhiteWalkerArmy, this.SevenKingdomArmy);
                    nextArmyToStrike = this.SevenKingdomArmy.ArmyName;
                }

                this.Fight(nextArmyToStrike);
            }
        }

        internal void Attack(Army attackers, Army defenders)
        {
            int attackValue = attackers.AttackValue();

            attackValue = this.Attack(defenders.Infantry, attackValue);

            this.Attack(defenders.Elite, attackValue);

            bool hasDefendersLostCount = defenders.Elite.Count <= 0 && defenders.Infantry.Count <= 0;
            if (hasDefendersLostCount)
            {
                this.WinnerArmyName = attackers.ArmyName;
            }
        }

        internal int Attack(Soldiers soldiers, int attackValue)
        {
            bool hasWindowForAttack = attackValue > soldiers.Defence && soldiers.Count > 0;
            if (hasWindowForAttack)
            {
                soldiers.Count--;
                attackValue -= soldiers.Defence;

                return this.Attack(soldiers, attackValue);
            }

            return attackValue;
        }
    }
}

