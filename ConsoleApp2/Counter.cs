namespace ConsoleApp2
{
    public class Counter
    {
        private int _min;
        private int _max;
        public int cur { get; set; }
        public int min
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value;
            }
        }
        public int max
        {
            get
            {
                return _max;
            }
            set
            {
                _max = value;
            }
        }

        public Counter()
        {
            max = 100;
            min = 0;
            cur = min;
        }

        public Counter(int min, int max)
        {
            if (min > max)
                throw new Exception("Min can not be less than max");
            this.min = min;
            this.max = max;
            cur = min;
        }

        public void increment()
        {
            cur++;
            if (cur == max)
                cur = min;
        }
        public void decrement()
        {
            if (cur != min)
                cur--;
        }

        public override string ToString()
        {
            return cur.ToString();
        }
    }
}
