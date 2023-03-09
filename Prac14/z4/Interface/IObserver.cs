using z4.Model;

namespace z4.Interface
{
    internal interface IObserver
    {
        void Update(Video video);
        void WhenSubscribing(Blogger blogger);
        void WhenUnsubscribing(Blogger blogger);
    }
}
