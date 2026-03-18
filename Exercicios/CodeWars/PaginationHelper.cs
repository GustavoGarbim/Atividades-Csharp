namespace Exercicios.CodeWars
{

    /*
     Dada uma coleção e quantidade de itens por pagina, deve criar uma paginação, onde cada página terá uma quantia de itens.
     */

    public class PaginationHelper<T>
    {
        private IList<T> _collection;
        private int _itemsPerPage;

        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            _collection = collection;
            _itemsPerPage = itemsPerPage;
        }

        public int ItemCount
        {
            get { return _collection.Count; }
        }

        public int PageCount
        {
            get
            {
                return (int)Math.Ceiling((double)_collection.Count / _itemsPerPage);
            }
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= PageCount)
            {
                return -1;
            }

            if (pageIndex == PageCount - 1)
            {
                int resto = _collection.Count % _itemsPerPage;
                return resto == 0 ? _itemsPerPage : resto;
            }

            return _itemsPerPage;
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= _collection.Count || _collection.Count == 0)
            {
                return -1;
            }

            return itemIndex / _itemsPerPage;
        }
    }
}
