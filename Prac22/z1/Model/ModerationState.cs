namespace z1.Model
{
    internal class ModerationState : StateDocument
    {
        public override void NextState(Document doc)
        {
            doc.State = new PublishedState();
            Console.WriteLine("Документ сменил состаяние с модрерации на публиковаеый ");
        }

        public override void BackState(Document doc)
        {
            doc.State = new DraftState();
            Console.WriteLine("Документ сменил состаяние с модрерации на черновик");
        }

        public override string ToString()
        {
            return "На модерации";
        }
    }
}
