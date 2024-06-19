namespace DangerBug
{
    internal class Mygg : Bug
    {
        public string Extra { get; }
        public Mygg()
        {
            Name = "Mygg";
            CanBite = true;
            HasLegs = true;
            Movement = "Fly og gå";
            Nuisance = "Kløe";
            Extra = "Suger blod";
            Benefit = "None";
        }
        public override string GetAllInfo => $"{base.GetAllInfo}, Ekstra info: {Extra}";
    }
}
