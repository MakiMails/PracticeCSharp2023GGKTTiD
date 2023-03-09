using z4.Interface;

namespace z4.Model
{

    internal class Blogger
    {
        delegate void UpdateBloger(Video video);
        event UpdateBloger? ub;

        private string _name;
        
        public string Name { get => _name; }

        public Blogger(string name)
        {
            _name = name;
        }

        public void Attach(IObserver observer)
        {
            ub += observer.Update;
            observer.WhenSubscribing(this);
        }

        public void Detach(IObserver observer)
        {
            ub -= observer.Update;
            observer.WhenUnsubscribing(this);
        }

        public void Notify(Video video)
        {
            ub?.Invoke(video);
        }

        public void CreateNewVideo(string nameVideo)
        {
            Video video = new Video()
            {
                Author = this,
                Name = nameVideo
            };
            Notify(video);
        }
    }

}
