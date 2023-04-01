namespace z1.Models
{
    internal class Payment
    {
        private int _codeTravelPackage;
        private DateOnly _datePayments;
        private decimal _sum;

        public int CodeTrravelPackage
        {
            get => _codeTravelPackage;
            set => _codeTravelPackage = value;
        }

        public DateOnly DatePayments
        {
            get => _datePayments;
            set => _datePayments = value;
        }

        public decimal Sum
        {
            get => _sum;
            set => _sum = value;
        }

        public Payment(int codeTravelPackage, DateOnly datePayments,
            decimal sum)
        {
            _codeTravelPackage = codeTravelPackage;
            _datePayments = datePayments;
            _sum = sum;
        }
    }
}
