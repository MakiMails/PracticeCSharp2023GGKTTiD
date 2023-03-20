namespace z1.Model
{
    internal class DraftState : StateDocument
    {
        public override void NextState(Document doc)
        {
            doc.State = new ModerationState();
            Console.WriteLine("Документ сменил состаяние с черновика на модрерацию");
        }

        public override void BackState(Document doc)
        {
            Console.WriteLine("Документ является черновиком. Это минимальное состояние для документа");
        }

        public override string ToString()
        {
            return "Черновик";
        }
    }
}
