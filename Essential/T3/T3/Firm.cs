using System.Collections.Generic;
using System.Linq;

namespace T3
{
    class Firm: IFirm
    {
        private static IList<IEmployee> _employees;

        public Firm()
        {
            _employees = new List<IEmployee>();
        }

        public IList<IEmployee> Employees => _employees;

        public static bool operator +(Firm currentFirm, IEmployee currentEmployee)
        {
            if (currentFirm.Employees.Contains(currentEmployee))
            {
                return false;
            }

            currentFirm.Employees.Add(currentEmployee);

            return true;
        }

        public static bool operator -(Firm currentFirm, IEmployee currentEmployee)
        {
            if (currentFirm.Employees.Contains(currentEmployee))
            {
                currentFirm.Employees.Remove(currentEmployee);
                return true;
            }

            return false;
        }

        public static bool operator -(Firm currentFirm, string employeeName)
        {
            if (currentFirm.Employees.Any(employee => employee.Name == employeeName))
            {
                //currentFirm.Employees.Remove(employeeName);
                return true;
            }

            return false;
        }
    }
}
