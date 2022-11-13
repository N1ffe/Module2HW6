using Module2HW6.Entities;

namespace Module2HW6.Interfaces
{
    public interface IHomeService
    {
        void Show(ElectricalAppliance[] array);
        void Sort(ElectricalAppliance[] array);
        void Find(ElectricalAppliance[] array);
    }
}
