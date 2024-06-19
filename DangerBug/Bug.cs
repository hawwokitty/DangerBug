namespace DangerBug
{
    internal class Bug
    {
        public string Name { get; set; }
        public bool CanBite { get; set; }
        public bool HasLegs { get; set; }
        public string Movement { get; set; }
        public string Nuisance { get; set; }
        public string Benefit { get; set; }

        public Bug()
        {
            
        }

        public Bug(string name, bool canBite, bool hasLegs, string movement, string nuisance, string benefit)
        {
            Name = name;
            CanBite = canBite;
            HasLegs = hasLegs;
            Movement = movement;
            Nuisance = nuisance;
            Benefit = benefit;
        }
        public virtual string GetAllInfo =>
            $"Type: {Name}, Kan bite: {CanBite}, Har bein: {HasLegs}, Måten {Name} beveger seg på: {Movement}, Plage: {Nuisance}, GoodStuff: {Benefit}";
    }
}
