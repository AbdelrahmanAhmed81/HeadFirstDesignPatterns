using DesignPatterns.Gankro.Spells;

namespace DesignPatterns.Gankro
{
    internal class GankroBag
    {
        public ISpell[] spells;
        public GankroBag(ISpell spell1 , ISpell spell2 , ISpell spell3)
        {
            spells = new ISpell[3];
            spells[0] = spell1;
            spells[1] = spell2;
            spells[2] = spell3;
        }
    }
}