using static System.Net.Mime.MediaTypeNames;

namespace z3.Model
{
    internal class Record
    {
        private DateOnly _dateCreate;
        private string _text;

        public DateOnly Date { get => _dateCreate; }
        public string Text { get => _text; }

        public Record(DateOnly dateCreate, string text)
        {
            _dateCreate = dateCreate;
            _text = text;
        }

        public Record DeepCopy() => new Record( new DateOnly(_dateCreate.Year,_dateCreate.Month,_dateCreate.Day),
            String.Copy(_text));

        public override string ToString()
        {
            return $"Data: {_dateCreate}\n" +
                $"Text: {_text}";
        }

    }
}
