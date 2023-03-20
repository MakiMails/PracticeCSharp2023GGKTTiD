namespace z1.Model
{
    internal class Document
    {
        private StateDocument _state;
        private string _name;
        private string _text;

        public StateDocument State { get => _state; set => _state = value; }

        public Document(string name, string text)
        {
            _state = new DraftState();
            _text = text;
        }

        public void ToPublish()
        {
            _state.NextState(this);
        }

        public void LowerState()
        {
            _state.BackState(this);
        }

        public override string ToString()
        {
            return $"Название: {_name}\n" +
                $"Статус: {_state}\n" +
                $"{_text}\n";
        }
    }
}
