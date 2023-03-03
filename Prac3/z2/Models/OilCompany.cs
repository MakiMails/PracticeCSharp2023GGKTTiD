namespace z2.Models
{
    public class OilCompany : Organization
    {
        public OilCompany(string name, string fullNameOwner, decimal profit) : base(name, fullNameOwner, profit)
        {
        }

        public void PumpOil()
        {
            Console.WriteLine("Нефт. комп. качает нефть");
        }
    }
}
