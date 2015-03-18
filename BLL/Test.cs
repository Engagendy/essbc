using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Test
    {
        Manager manager = 
            EmployeeFactory.CreateEmployee
            (EmployeeType.Manager,"ahmed",10,100,1000) as Manager; 

    }
}
