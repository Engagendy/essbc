using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class EmployeeFactory
    {
        public static IEmployee 
            CreateEmployee(EmployeeType type,string name,int age,int ID, decimal salary)
        {
            IEmployee employee = null;
            switch (type){
                case EmployeeType.Accountant:
                    employee = new Accountant(ID,name,salary,age);
                    break;
                case EmployeeType.Engineer:
                    employee = new Engineer(ID, name, salary, age);
                    break;
                    case EmployeeType.Manager:
                    employee = new Manager(ID, name, salary, age);
                    break;
                    case EmployeeType.Worker:
                    employee = new Worker(ID, name, salary, age);
                    break;
                default:
                    break;
            }

            

            return employee; 
        }
    }
}
