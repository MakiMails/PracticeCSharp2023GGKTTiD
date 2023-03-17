namespace z3.Model
{
    internal class Diary
    {
        private Dictionary<int, Record> _records = new Dictionary<int, Record>();
        private string _ownerName;
        private IdInfo _idInfo;

        public Dictionary<int, Record> Records { get => _records; }

        public Diary(string ownerName, IdInfo idInfo)
        {
            _ownerName = ownerName;
            _idInfo = idInfo;
        }

        public Diary ShallowCopy() => (Diary)this.MemberwiseClone();

        public Diary DeepCopy()
        {
            Diary clone = (Diary)this.MemberwiseClone();
            clone._records = new Dictionary<int, Record>();
            foreach (var couple in _records)
            {
                clone._records.Add(couple.Key, couple.Value.DeepCopy());
            }
            clone._ownerName = String.Copy(_ownerName);
            clone._idInfo = new IdInfo(_idInfo.IdNumber);
            return clone;
        }

        public void Add(string text)
        {
            DateOnly date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Record record = new Record(date, text);
            _records.Add(_records.Keys.Count + 1, record);
        }

        public override string ToString()
        {
            return $"Id: {_idInfo}\n" +
                $"Owner: {_ownerName}\n" +
                $"Count records: {_records.Count}";
        }

    }
}
