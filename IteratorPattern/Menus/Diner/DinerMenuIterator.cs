using System.Collections;

namespace DesignPatterns.IteratorPattern.Menus.Diner
{
    internal class DinerMenuIterator : IEnumerator /*IIterator*/
    {
        MenuItem[] items;
        int position = -1;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public object Current => items[position];

        public bool MoveNext()
        {
            if (position + 1 < items.Length && items[position + 1] != null)
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
        //    return position < items.Length && items[position] != null;
        //}

        //public MenuItem next()
        //{
        //    return items[position++];
        //}
        #endregion
    }
}
