namespace ConsoleApp2
{
    public class Fraction
    {
        private int _nominator;
        private int _denominator;
        public int numerator
        {
            get { return _nominator; }
            set
            {
                _nominator = value;
            }
        }
        public int denominator
        {
            get { return _denominator; }
            set
            {
                _denominator = value;
            }
        }
        public Fraction(int num, int denom)
        {
            if (denom == 0)
                throw new Exception("Denominator can not be zero");
            numerator = num;
            denominator = denom;
        }

        public void Simplify()
        {
            for (int i = 1; i < denominator && i < numerator; i++)
            {
                if (denominator % i == 0 && numerator % i == 0)
                {
                    denominator /= i;
                    numerator /= i;
                }
            }
        }
        public Fraction Add(Fraction other)
        {
            int num = (other.denominator * this.numerator + this.denominator * other.numerator);
            int denom = this.denominator * other.denominator;
            Fraction f = new(num, denom);
            return f;
        }
        public Fraction Substract(Fraction other)
        {
            int num = (other.denominator * this.numerator - this.denominator * other.numerator);
            int denom = this.denominator * other.denominator;
            Fraction f = new(num, denom);
            return f;
        }
        public Fraction Multiplication(Fraction other)
        {
            int num = this.numerator * other.numerator; ;
            int denom = this.denominator * other.denominator;
            Fraction f = new(num, denom);
            return f;
        }
        public Fraction Division(Fraction other)
        {
            int num = this.numerator * other.denominator; ;
            int denom = this.denominator * other.numerator;
            Fraction f = new(num, denom);
            return f;
        }
        public override string ToString()
        {
            return $@"
{numerator}
----
{denominator}";
        }
    }
}
