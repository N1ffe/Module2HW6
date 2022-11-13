using Module2HW6.Entities;
using Module2HW6.Enums;
using Module2HW6.Extensions;
using Module2HW6.Interfaces;

namespace Module2HW6.Services
{
    public class HomeService : IHomeService
    {
        public void Show(ElectricalAppliance[] array)
        {
            foreach (ElectricalAppliance ea in array)
            {
                if (ea is null)
                {
                    break;
                }
                Console.WriteLine($"Name: {ea.Name}, Power: {ea.Power}W, Plugged: {ea.IsPlugged}, Active: {ea.IsWorking}");
            }
            Console.WriteLine();
        }
        public void Sort(ElectricalAppliance[] array)
        {
            int opt;
            bool reverse;
            Console.WriteLine("Choose parameter to sort by:\n1. Name\n2. Power\n3. Plug status\n4. Activity");
            opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Sort by:\n1. Ascending\n2. Descending");
            reverse = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()) - 1);
            Console.WriteLine();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    switch (opt)
                    {
                        case 1:
                            if ((array[j].Name.ToLower()[0] > array[j + 1].Name.ToLower()[0] && !reverse) || (array[j].Name.ToLower()[0] < array[j + 1].Name.ToLower()[0] && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case 2:
                            if ((array[j].Power > array[j + 1].Power && !reverse) || (array[j].Power < array[j + 1].Power && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case 3:
                            if (((Convert.ToInt32(array[j].IsPlugged) > Convert.ToInt32(array[j + 1].IsPlugged)) && !reverse)
                                || ((Convert.ToInt32(array[j].IsPlugged) < Convert.ToInt32(array[j + 1].IsPlugged)) && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                        case 4:
                            if (((Convert.ToInt32(array[j].IsWorking) > Convert.ToInt32(array[j + 1].IsWorking)) && !reverse)
                                || ((Convert.ToInt32(array[j].IsWorking) < Convert.ToInt32(array[j + 1].IsWorking)) && reverse))
                            {
                                SwitchTwo(array, j);
                            }
                            break;
                    }
                }
            }
        }
        public void Find(ElectricalAppliance[] array)
        {
            int opt, iValue = 0;
            string op, sValue = string.Empty;
            bool bValue = false;
            ElectricalApplianceParametersEnum.ElectricalApplianceParameters parameter = ElectricalApplianceParametersEnum.ElectricalApplianceParameters.Name;
            ComparisonOperatorsEnum.Operators enumOp = ComparisonOperatorsEnum.Operators.EqualTo;
            Console.WriteLine("Choose parameter to look for:\n1. Name\n2. Power\n3. Plug status\n4. Activity");
            opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (opt)
            {
                case 1:
                    parameter = ElectricalApplianceParametersEnum.ElectricalApplianceParameters.Name;
                    break;
                case 2:
                    parameter = ElectricalApplianceParametersEnum.ElectricalApplianceParameters.Power;
                    break;
                case 3:
                    parameter = ElectricalApplianceParametersEnum.ElectricalApplianceParameters.IsPlugged;
                    break;
                case 4:
                    parameter = ElectricalApplianceParametersEnum.ElectricalApplianceParameters.IsWorking;
                    break;
            }
            if (opt == 2)
            {
                Console.Write("Enter operator (<, <=, =, >, >=): ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "<":
                        enumOp = ComparisonOperatorsEnum.Operators.LessThan;
                        break;
                    case "<=":
                        enumOp = ComparisonOperatorsEnum.Operators.LessThanOrEqualTo;
                        break;
                    case "=":
                        enumOp = ComparisonOperatorsEnum.Operators.EqualTo;
                        break;
                    case ">":
                        enumOp = ComparisonOperatorsEnum.Operators.GreaterThan;
                        break;
                    case ">=":
                        enumOp = ComparisonOperatorsEnum.Operators.GreaterThanOrEqualTo;
                        break;
                }
            }
            Console.Write("Enter value: ");
            if (opt == 1)
            {
                sValue = Console.ReadLine();
            }
            else if (opt == 2)
            {
                iValue = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                bValue = Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine();
            switch (opt)
            {
                case 1:
                    Show(array.Find(sValue));
                    break;
                case 2:
                    Show(array.Find(enumOp, iValue));
                    break;
                case 3:
                    Show(array.Find(parameter, bValue));
                    break;
                case 4:
                    Show(array.Find(parameter, bValue));
                    break;
            }
        }
        private void SwitchTwo(ElectricalAppliance[] array, int i)
        {
            ElectricalAppliance ea1 = (ElectricalAppliance)array[i].Clone();
            ElectricalAppliance ea2 = (ElectricalAppliance)array[i + 1].Clone();
            array[i] = ea2;
            array[i + 1] = ea1;
        }
    }
}
