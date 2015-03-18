using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Employee: IEmployee
    {
        #region properties

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        #endregion

        public Employee(int ID, string name, decimal salary, int age)
        {
            this.Age = age;
            this.Name = name;
            this.Salary = salary;
            this.ID = ID; 
        }

        public virtual string DoWork()
        {
            throw new NotImplementedException();
        }

        public virtual decimal HourlySalaryRate()
        {
            return this.Salary / (8 * 22); 
        }
    }
}
