using System.Collections;

namespace DesignPatterns.IteratorPattern.Menus.PancakeHouse
{
    internal class PancakeHouseMenuIterator : IEnumerator /*IIterator*/
    {
        ArrayList items;
        int position = -1;
        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;
        }
        public object Current => items[position];

        public bool MoveNext()
        {
            if (position + 1 < items.Count)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        #region using our IIterator
        //public bool hasNext()
        //{
        //    return position < items.Count;
        //}

        //public MenuItem next()
        //{
        //    return items[position++] as MenuItem;
        //}
        #endregion
    }
}
