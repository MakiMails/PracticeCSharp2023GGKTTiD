namespace z1.Model
{
    internal class PublishedState : StateDocument
    {
        public override void NextState(Document doc)
        {
            Console.WriteLine("Документ является публикованным, следующего состояния нет");
        }

        public override void BackState(Document doc)
        {
            doc.State = new ModerationState();
            Console.WriteLine("Документ сменил состаяние с публиковоный на модрерацию");
        }

        public override string ToString()
        {
            return "Опубликован";
        }
    }
}
