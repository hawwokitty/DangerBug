namespace DangerBug
{
    internal class Flått : Bug
    {
        public Flått()
        {
            Name = "Flått";
            CanBite = true;
            HasLegs = true;
            Movement = "Kryper";
            Nuisance = "Kan gi alvorlig sykdom";
            Benefit = "None";
        }
    }
}
