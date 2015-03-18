using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Engineer : Employee
    {
        public Engineer(int ID, string name, decimal salary, int age)
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
            return string.Format("I am {0} an Engineer", this.Name);
        }
    }
}
