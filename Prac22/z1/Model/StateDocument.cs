namespace z1.Model
{
    internal abstract class StateDocument
    {
        public abstract void NextState(Document doc);
        public abstract void BackState(Document doc);
        public abstract override string ToString();
    }
}
