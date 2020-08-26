using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkersBase
{
    class Base
    {
        private readonly List<Workers> _workerses;

        public Base()
        {
            _workerses = new List<Workers>();
        }

        public void Add(Workers workers)
        {
            _workerses.Add(workers);
        }

        public void Remove(string workersName)
        {
            var workerForRemove = _workerses.FirstOrDefault(work => work.Name == workersName);
            if (workerForRemove == null)
            {
                throw new SystemException("Can't remove");
            }

            _workerses.Remove(workerForRemove);
        }

        public string GetInvoice()
        {
            var invoice = string.Format($"WorkersBase:\n");
            int index = 0;
            foreach (var product in _workerses)
            {
                invoice += $"{++index}. {product.Name} - {product.Position} -{product.Experience} -- {product.Salary}\n";
            }

            return invoice;
        }
        public void ChangeSalary(string workersSalary)
        {
            var salaryForChange = _workerses.FirstOrDefault(work => work.Salary == workersSalary);
            if (salaryForChange == null)
            {
                throw new SystemException("Can't remove");
            }

            //_workerses.(salaryForChange);
        }
    }
}
