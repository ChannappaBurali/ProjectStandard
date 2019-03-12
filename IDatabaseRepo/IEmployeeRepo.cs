using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomModels;

namespace IDatabaseRepo
{  
    public interface IEmployeeRepo
    {
        IEnumerable<Models> GetAllEmp();
        IEnumerable<Models> GetEmp(int id);
        void SaveEmp();
    }
}
