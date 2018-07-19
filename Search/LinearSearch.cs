namespace Search
{
    public class LinearSearch
    {
        #region :: Fields ::

        private readonly int _arraySize = 100;
        private readonly bool _useMockData;
        private int[] _array;
        private int _searchElement;

        #endregion

        #region :: Constructor ::

        public LinearSearch(bool useMockData = true)
        {
            System.Console.WriteLine("\n:: Linear Search ::\n");
            _useMockData = useMockData;
            if(!_useMockData) return;
            _array = Base.Common.Utility.GetMockArray(_arraySize);
            _searchElement = _array[Base.Common.Utility.GetRandomNumber(0, _array.Length - 1)];
        }

        #endregion

        #region :: Methods ::

        public int Search(int? searchElement = null)
        {
            if (_useMockData) return FindElement(_array, _searchElement);
            _array = Utility.GetArrayInput() ?? Base.Common.Utility.GetMockArray(_arraySize);
            if (searchElement == null)
                _searchElement = Utility.GetSearchElementInput() ??
                                 _array[Base.Common.Utility.GetRandomNumber(0, _array.Length - 1)];
            else
                _searchElement = searchElement.Value;

            return FindElement(_array, _searchElement);
        }

        public int Search(int[] array, int searchElement)
        {
            return FindElement(array, searchElement);
        }

        private int FindElement(int[] array, int searchElement)
        {
            if (array == null)
            {
                System.Console.WriteLine("Null Array !");
                return -1;
            }
            if (_array.Length <= 0) return -1;
            System.Console.WriteLine("Array Size                : " + array.Length);
            System.Console.WriteLine("Search Element            : " + searchElement);
            for (var i = 0; i < array.Length; i++)
            {
                if (searchElement != array[i]) continue;
                System.Console.WriteLine("Element found at Index    : " + i);
                return i;
            }
            System.Console.WriteLine("Element not found !");
            return -1;
        }

        #endregion
    }
}
