namespace TheHackingofWinterfell
{
    public class Army
    {
        public Army(Soldiers elite, Soldiers infantry, string armyName)
        {
            this.Elite = elite;
            this.Infantry = infantry;
            this.ArmyName = armyName;
        }

        public Soldiers Elite { get; private set; }

        public Soldiers Infantry { get; private set; }

        public string ArmyName { get; private set; }

        public int AttackValue()
        {
            return this.Elite.GivenDamage * this.Elite.Count +
                    this.Infantry.GivenDamage * this.Infantry.Count;
        }
    }
}
