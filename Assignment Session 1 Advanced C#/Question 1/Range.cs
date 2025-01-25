namespace Assignment_Session_1_Advanced_C_.Question_1
{
    internal class Range<T>  where T : IComparable<T> , IConvertible
    {
        #region Properties
        
        public T Value { get; set; }
        public T minimum { get; set; }

        public T maximum { get; set; } 
        #endregion

        #region Constructors
        public Range(T minimum, T maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }
        #endregion

        #region Methods

        //Creating IsInRange(T value) Method
        public bool IsInRange(T Value)
        {
            return Value.CompareTo(minimum) >= 0 && Value.CompareTo(maximum) <= 0;  
        }
        //Creating Method Length()
        public int Length()
        {
            int Max = Convert.ToInt32(maximum);
            int Min = Convert.ToInt32(minimum);
            return Max - Min;
        }

        #endregion
    }
}
