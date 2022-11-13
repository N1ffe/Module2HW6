﻿namespace Module2HW6.Entities
{
    public class Lightbulb : ElectricalAppliance
    {
        public Lightbulb(string name, int power)
            : base(name, power)
        {
        }
        private Lightbulb(string name, int power, bool isPlugged, bool isWorking)
            : base(name, power)
        {
            IsPlugged = isPlugged;
            IsWorking = isWorking;
        }
        public override void PlugIn()
        {
            Console.WriteLine($"{Name} has been screwed in");
            IsPlugged = true;
        }
        public override void PlugOut()
        {
            Console.WriteLine($"{Name} has been screwed out");
            IsPlugged = false;
        }
        public override void TurnOn()
        {
            if (IsPlugged)
            {
                Console.WriteLine($"{Name} is glowing now");
                IsWorking = true;
            }
            else
            {
                Console.WriteLine($"{Name} is not screwed in");
            }
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} has been turned off");
            IsWorking = false;
        }
        public override object Clone()
        {
            return new Lightbulb(Name, Power, IsPlugged, IsWorking);
        }
    }
}
