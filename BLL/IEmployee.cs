using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IEmployee
    {


    #region methods

        string DoWork();
        decimal HourlySalaryRate();

    #endregion 

    }
}
