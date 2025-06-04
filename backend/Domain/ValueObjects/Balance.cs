namespace Domain.ValueObjects
{
    public class Balance
    {
        private const int MaxDigits = 15;

        public decimal Value { get; private set; }

        public Balance(decimal value)
        {
            if (value.ToString("F0").Length > MaxDigits)
                throw new ArgumentException($"Balance exceeds {MaxDigits} significant digits");

            Value = value;
        }
        
    }
}