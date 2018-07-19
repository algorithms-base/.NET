using System.Linq;

namespace Search
{
    public class BinarySearch
    {
        #region :: Fields ::

        private readonly int _arraySize = 100;
        private readonly bool _useMockData;
        private int[] _array;
        private int _searchElement;

        #endregion

        #region :: Constructor ::

        public BinarySearch(bool useMockData = true)
        {
            System.Console.WriteLine("\n:: Binary Search ::\n");
            _useMockData = useMockData;
            if (!_useMockData) return;
            _array = Base.Common.Utility.GetMockArray(_arraySize);
            _searchElement = _array[Base.Common.Utility.GetRandomNumber(0, _array.Length - 1)];
        }

        #endregion

        #region :: Methods ::

        public int Search(int? searchElement = null)
        {
            if (!_useMockData)
            {
                _array = Utility.GetArrayInput() ?? Base.Common.Utility.GetMockArray(_arraySize);
                if (searchElement == null)
                    _searchElement = Utility.GetSearchElementInput() ??
                                     _array[Base.Common.Utility.GetRandomNumber(0, _array.Length - 1)];
            }
            if (_array.Length <= 0) return -1;
            if (searchElement != null)
                _searchElement = searchElement.Value;

            System.Console.WriteLine("Sorting Array");
            Base.Common.Utility.SortArray(ref _array);
            System.Console.WriteLine("Array Size                : " + _array.Length);
            System.Console.WriteLine("Search Element            : " + _searchElement);
            var index = RecursiveSearch(0, _array.Length - 1);
            if (index != -1)
                System.Console.WriteLine("Element found at Index    : " + index);
            else
                System.Console.WriteLine("Element not found !");
            return index;
        }

        private int RecursiveSearch(int low, int high)
        {
            if (_searchElement == _array[low])
                return low;
            if (_searchElement == _array[high])
                return high;
            if (low >= high)
                return -1;
            var mid = (high + low) / 2;
            if (_array[mid] < _searchElement)
                return RecursiveSearch(mid + 1, high);
            if (_array[mid] > _searchElement)
                return RecursiveSearch(low, mid - 1);
            return mid;
        }

        #endregion
    }
}
