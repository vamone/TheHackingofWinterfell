using System.Diagnostics;

namespace TheHackingofWinterfell
{
    [DebuggerDisplay("Count: {this.Count}, Damage: {this.GivenDamage}, Defence: {this.Defence}")]
    public class Soldiers
    {
        public Soldiers(int givenDamage, int defence, int count)
        {
            this.GivenDamage = givenDamage;
            this.Defence = defence;
            this.Count = count;
        }

        public int GivenDamage { get; set; }

        public int Defence { get; set; }

        public int Count { get; set; }
    }
}
