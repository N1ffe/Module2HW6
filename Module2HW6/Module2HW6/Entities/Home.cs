using Module2HW6.Interfaces;

namespace Module2HW6.Entities
{
    public class Home
    {
        public Home(ElectricalAppliance[] electricalAppliances, IHomeService homeService)
        {
            ElectricalAppliances = electricalAppliances;
            HomeService = homeService;
        }
        public ElectricalAppliance[] ElectricalAppliances { get; set; }
        public IHomeService HomeService { get; set; }
    }
}
