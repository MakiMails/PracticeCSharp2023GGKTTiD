namespace z3.Model
{
    internal class IdInfo
    {
        private int _idNumber;

        public int IdNumber { get => _idNumber; }

        public IdInfo(int idNumber)
        {
            _idNumber = idNumber;
        }

        public override string ToString()
        {
            return _idNumber.ToString();
        }
    }
}
