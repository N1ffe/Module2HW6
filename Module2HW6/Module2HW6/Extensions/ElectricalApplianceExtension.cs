using Module2HW6.Entities;
using static Module2HW6.Enums.ComparisonOperatorsEnum;
using static Module2HW6.Enums.ElectricalApplianceParametersEnum;

namespace Module2HW6.Extensions
{
    public static class ElectricalApplianceExtension
    {
        public static ElectricalAppliance[] Find(this ElectricalAppliance[] array, Operators op, int value)
        {
            ElectricalAppliance[] result = new ElectricalAppliance[array.Length];
            int i = 0;
            foreach (ElectricalAppliance ea in array)
            {
                if (Compare(ea.Power, value, op))
                {
                    i += Func(result, i, ea);
                }
            }
            return result;
        }
        public static ElectricalAppliance[] Find(this ElectricalAppliance[] array, string value)
        {
            ElectricalAppliance[] result = new ElectricalAppliance[array.Length];
            int i = 0;
            foreach (ElectricalAppliance ea in array)
            {
                if (ea.Name.Contains(value))
                {
                    i += Func(result, i, ea);
                }
            }
            return result;
        }
        public static ElectricalAppliance[] Find(this ElectricalAppliance[] array, ElectricalApplianceParameters parameters, bool value)
        {
            ElectricalAppliance[] result = new ElectricalAppliance[array.Length];
            int i = 0;
            foreach (ElectricalAppliance ea in array)
            {
                if (parameters == ElectricalApplianceParameters.IsPlugged)
                {
                    if (ea.IsPlugged == value)
                    {
                        i += Func(result, i, ea);
                    }
                }
                else
                {
                    if (ea.IsWorking == value)
                    {
                        i += Func(result, i, ea);
                    }
                }
            }
            return result;
        }
        private static bool Compare(int value1, int value2, Operators op)
        {
            switch (op)
            {
                case Operators.LessThan:
                    return value1 < value2;
                case Operators.LessThanOrEqualTo:
                    return value1 <= value2;
                case Operators.EqualTo:
                    return value1 == value2;
                case Operators.GreaterThan:
                    return value1 > value2;
                case Operators.GreaterThanOrEqualTo:
                    return value1 >= value2;
                default:
                    return false;
            }
        }
        private static int Func(ElectricalAppliance[] array, int i, ElectricalAppliance ea)
        {
            array[i] = ea;
            return 1;
        }
    }
}
