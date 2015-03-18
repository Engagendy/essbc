using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Worker : Employee
    {
        public Worker(int ID, string name, decimal salary, int age)
            : base(ID, name, salary, age)
        {

        }
        public override string DoWork()
        {
            return this.ToString();
        }

        public override decimal HourlySalaryRate()
        {
            return base.HourlySalaryRate();
        }

        public override string ToString()
        {
            return string.Format("I am {0} an Worker", this.Name);
        }
    }
}
