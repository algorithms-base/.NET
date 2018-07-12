namespace Search
{
    public class LinearSearch
    {
        #region :: Fields ::

        private readonly int _arraySize = 100;
        private readonly int[] _array;
        private int _searchElement;

        #endregion

        #region :: Constructor ::

        public LinearSearch(bool useMockData = false)
        {
            System.Console.WriteLine("\n:: Linear Search ::\n");
            if (useMockData)
            {
                _array = Utility.GetArrayInput() ?? Utility.GetMockArray(_arraySize);
                _searchElement = Utility.GetSearchElementInput() ?? _array[Utility.GetRandomNumber(0, _array.Length - 1)];
                return;
            }
            _array = Utility.GetMockArray(_arraySize);
            _searchElement = _array[Utility.GetRandomNumber(0, _array.Length - 1)];
        }

        #endregion

        #region :: Methods ::

        public int Search(int? searchElement = null)
        {
            _searchElement = searchElement ?? _searchElement;

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
