using Module2HW6.Entities;
using Module2HW6.Services;

namespace Module2HW6
{
    public class Starter
    {
        public void Run()
        {
            Home home = new Home(
                new ElectricalAppliance[]
                {
                new Lightbulb("Lightbulb 1", 10),
                new Lightbulb("Lightbulb 2", 12),
                new Lightbulb("Lightbulb 3", 15),
                new Fridge("Fridge 1", 900),
                new Toster("Toster 1", 800)
                },
                new HomeService());
            home.HomeService.Show(home.ElectricalAppliances);
            for (int i = 0; i < home.ElectricalAppliances.Length; i++)
            {
                home.ElectricalAppliances[i].PlugIn();
            }
            Console.WriteLine();
            home.ElectricalAppliances[0].TurnOn();
            home.ElectricalAppliances[1].TurnOn();
            home.ElectricalAppliances[3].TurnOn();
            Console.WriteLine();
            home.HomeService.Sort(home.ElectricalAppliances);
            home.HomeService.Show(home.ElectricalAppliances);
            home.HomeService.Find(home.ElectricalAppliances);
            for (int i = 0; i < home.ElectricalAppliances.Length; i++)
            {
                if (home.ElectricalAppliances[i].IsWorking)
                {
                    home.ElectricalAppliances[i].TurnOff();
                }
            }
        }
    }
}
