using System.Security.Cryptography;
using z4.Interface;
namespace z4.Model
{
    internal class Subscriber : IObserver
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void WhenSubscribing(Blogger blogger) => Console.WriteLine($"Подписчик {_name} подписался на блогера: {blogger.Name} ");

        public void WhenUnsubscribing(Blogger blogger) => Console.WriteLine($"Подписчик {_name} отписался от блогера: {blogger.Name}");

        public void Update(Video video)
        {
            Console.WriteLine($"Подписчик {_name} был уведомлен об выходе видео " +
                $"под названием {video.Name} " +
                $"от блогера {video.Author.Name}");
        }
    }
}
