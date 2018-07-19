
namespace Search
{
    public class JumpSearch
    {
        #region :: Fields ::

        private readonly int _arraySize = 100;
        private readonly bool _useMockData;
        private int[] _array;
        private int _searchElement;

        #endregion

        #region :: Constructor ::

        public JumpSearch(bool useMockData = true)
        {
            System.Console.WriteLine("\n:: Jump Search ::\n");
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
            var jumpSize = (int)System.Math.Sqrt(_array.Length);
            System.Console.WriteLine("Jump Size                 : " + jumpSize);
            int low = 0, high = jumpSize, index = -1, totalJumps = 0;
            while (high > low)
            {
                if (high > _array.Length - 1)
                {
                    index = -1;
                    break;
                }
                if (_array[high] < _searchElement)
                {
                    low = high + 1;
                    high += jumpSize;
                    if (high >= _array.Length)
                        high = _array.Length - 1;
                    totalJumps++;
                    continue;
                }
                for (var i = low; i <= high; i++)
                {
                    if (_searchElement != _array[i]) continue;
                    index = i;
                    break;
                }
                if ((_array[high] > _searchElement && index == -1) || index != -1)
                    break;
            }

            if (index != -1)
                System.Console.WriteLine("Element found at Index    : " + index);
            else
                System.Console.WriteLine("Element not found !");

            System.Console.WriteLine("Total Jumps               : " + totalJumps);
            return index;
        }

        #endregion
    }
}
