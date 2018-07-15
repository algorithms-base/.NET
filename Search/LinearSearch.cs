namespace Search
{
    public class LinearSearch
    {
        #region :: Fields ::

        private readonly int _arraySize = 100;
        private int[] _array;
        private int _searchElement;

        #endregion

        #region :: Constructor ::

        public LinearSearch()
        {
            System.Console.WriteLine("\n:: Linear Search ::\n");
            _array = Base.Common.Utility.GetMockArray(_arraySize);
            _searchElement = _array[Base.Common.Utility.GetRandomNumber(0, _array.Length - 1)];
        }

        #endregion

        #region :: Methods ::

        public int Search(bool useMockData = true)
        {
            if (!useMockData)
            {
                _array = Utility.GetArrayInput() ?? _array;
                _searchElement = Utility.GetSearchElementInput() ?? _searchElement;
            }

            System.Console.WriteLine("Array Size                : " + _array.Length);
            System.Console.WriteLine("Search Element            : " + _searchElement);
            for (var i = 0; i < _array.Length; i++)
            {
                if (_searchElement != _array[i]) continue;
                System.Console.WriteLine("Element found at Index    : " + i);
                return i;
            }
            System.Console.WriteLine("Element not found !");
            return -1;
        }

        #endregion
    }
}
