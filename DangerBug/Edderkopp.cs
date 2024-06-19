namespace DangerBug
{
    internal class Edderkopp : Bug
    {
        public Edderkopp()
        {
            Name = "Edderkopp";
            CanBite = false;
            HasLegs = true;
            Movement = "Kryper";
            Nuisance = "Kan bite mennesker";
            Benefit = "Spiser husfluer og midd";
        }
    }
}
