namespace DangerBug
{
    internal class Husflue : Bug
    {
        public Husflue()
        {
            Name = "Husflue";
            CanBite = false;
            HasLegs = true;
            Movement = "Fly og gå";
            Nuisance = "Kan spre sykdommer";
            Benefit = "None";
        }
    }
}
