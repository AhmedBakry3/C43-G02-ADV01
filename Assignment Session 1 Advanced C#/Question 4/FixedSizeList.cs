namespace Assignment_Session_1_Advanced_C_.Question_4
{
    public class FixedSizeList<T>
    {
        #region Attributes
        private T[] _items;
        private int _count;
        #endregion

        #region Properties

        // Property to get the current count of elements in the list
        public int Count
        {
            get { return _count; }
        }

        // Property to get the fixed capacity of the list
        public int Capacity
        {
            get { return _items.Length; }
        }
        public T[] Items
        {
            get { return _items; }
        }
        #endregion

        #region Constructors

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero");
            }

            _items = new T[capacity];
            _count = 0;
        }
        #endregion

        // Add method 
        public void Add(T item)
        {
            if (_count >= _items.Length)
            {
                throw new InvalidOperationException("Cannot add more elements, the list is full");
            }

            _items[_count] = item;
            _count++;
        }

        //Get Method
        public T Get(int index)
        {
            if (index < 0 || index >= _count)  // Check if the index is valid
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return _items[index];
        }

    }
}
