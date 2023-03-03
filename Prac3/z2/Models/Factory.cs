namespace z2.Models
{
    public class Factory : Organization
    {
        public Factory(string name, string fullNameOwner, decimal profit) : base(name, fullNameOwner, profit)
        {
        }

        public void Work()
        {
            Console.WriteLine("Завод работает");
        }
    }
}
