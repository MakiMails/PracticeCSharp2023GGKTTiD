using z4.Interface;

namespace z4.Model
{
    internal class Moderator : IObserver
    {
        private string _id;

        public Moderator(string id)
        {
            _id = id;
        }

        public void WhenSubscribing(Blogger blogger) => Console.WriteLine($"Модератор под id: {_id} прикреплен к блогеру: {blogger.Name} ");

        public void WhenUnsubscribing(Blogger blogger) => Console.WriteLine($"Модератор под id: {_id} откреплен от блогера: {blogger.Name}");

        public void Update(Video video)
        {
            Console.WriteLine($"Модератор под id: {_id} был уведомлен об выходе видео " +
                $"под названием {video.Name} " +
                $"от блогера {video.Author.Name}");
        }
    }
}
