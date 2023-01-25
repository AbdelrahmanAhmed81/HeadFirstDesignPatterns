using DesignPatterns.Gankro.Monsters;

namespace DesignPatterns.Gankro.Spells
{
    internal class Spell : ISpell
    {
        IDoll monster;
        public Spell(IDoll monster)
        {
            this.monster = monster;
        }
        public void UseSpell()
        {
            monster.RevealMonster();
        }
    }
}
