namespace Module2HW6.Entities
{
    public abstract class ElectricalAppliance : ICloneable
    {
        protected ElectricalAppliance(string name, int power)
        {
            Name = name;
            Power = power;
            IsPlugged = false;
            IsWorking = false;
        }
        public string Name { get; set; }
        public int Power { get; set; }
        public bool IsPlugged { get; protected set; }
        public bool IsWorking { get; protected set; }
        public abstract void PlugIn();
        public abstract void PlugOut();
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract object Clone();
    }
}
