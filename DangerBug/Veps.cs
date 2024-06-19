namespace DangerBug
{
    internal class Veps : Bug
    {
        public Veps()
        {
            Name = "Veps";
            CanBite = false;
            HasLegs = true;
            Movement = "Fly og gå";
            Nuisance = "Giftig, kan gi alvorlig sykdom/død ved allergi";
            Benefit = "None";
        }
    }
}
