using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseRepo;
using ActualDataBaseRepo;
using CustomModels;
using IDatabaseRepo;

namespace BussinessRepo
{    
    public class EmployeeBLRepo
    {
        dbEntities db = new dbEntities();
        IEmployeeRepo emp;
        public EmployeeBLRepo(int n)
        {
            if (n == 1) {
                emp = new Employee();
            }
            if(n==2)
            {
               emp = new EmployeeRepo();
            }                
        }
  // EmployeeRepo emp = new EmployeeRepo();
     //   Employee emp = new Employee();
        public IEnumerable<Models> GetAllEmp()
        {
            //IEnumerable<empl> em;
            //em = db.empls.ToList();
            return emp.GetAllEmp();
        }

        public IEnumerable<empl> GetEmp(int id)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<empl> GetEmp(int id)
        //{
        //    return emRepo.GetEmp(id);
        //}
        public void SaveEmp()
        {
             emp.SaveEmp();
        }
    }
}
