namespace z1.Models
{
    internal class TravelPackage
    {
        private int _codeTurist;
        private int _codeSeason;

        public int CodeTurist
        {
            get => _codeTurist;
            set => _codeTurist = value;
        }

        public int CodeSeason
        {
            get => _codeSeason;
            set => _codeSeason = value;
        }
        public TravelPackage(int codeTurist, int codeSeason)
        {
            _codeTurist = codeTurist;
            _codeSeason = codeSeason;
        }
    }
}
