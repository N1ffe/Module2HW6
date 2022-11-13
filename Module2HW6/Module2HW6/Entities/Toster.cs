namespace Module2HW6.Entities
{
    public class Toster : ElectricalAppliance
    {
        public Toster(string name, int power)
            : base(name, power)
        {
        }
        private Toster(string name, int power, bool isPlugged, bool isWorking)
            : base(name, power)
        {
            IsPlugged = isPlugged;
            IsWorking = isWorking;
        }
        public override void PlugIn()
        {
            Console.WriteLine($"{Name} has been plugged in");
            IsPlugged = true;
        }
        public override void PlugOut()
        {
            Console.WriteLine($"{Name} has been plugged out");
            IsPlugged = false;
        }
        public override void TurnOn()
        {
            if (IsPlugged)
            {
                Console.WriteLine($"{Name} is making toasts");
                IsWorking = true;
            }
            else
            {
                Console.WriteLine($"{Name} is not plugged in");
            }
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} has been turned off");
            IsWorking = false;
        }
        public override object Clone()
        {
            return new Toster(Name, Power, IsPlugged, IsWorking);
        }
    }
}
