namespace z2.Models
{
    public class InsuranceСompany : Organization
    {
        public InsuranceСompany(string name, string fullNameOwner, decimal profit) : base(name, fullNameOwner, profit)
        {
        }

        public void InsureOrgan(Organization organization)
        {
            Console.WriteLine($"Старх. компания страхует {organization.Name}");
        }
    }
}
