using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDatabaseRepo;
using CustomModels;

namespace ActualDataBaseRepo
{
  public class Employee : IEmployeeRepo
    {
        dbEntities db = new dbEntities();
        public IEnumerable<Models> GetAllEmp()
        {
            IEnumerable<empl> em;
            em = db.empls.ToList();
            List<Models> emd=new List<Models>();
           // Models Md = new Models();
            foreach (var ob in em)
            {
                Models mdn = new Models();
                mdn.Id = ob.Id;
                mdn.Name = ob.Name;
                mdn.salary = ob.salary;
                emd.Add(mdn);
            }          
            return emd;
        }

        public IEnumerable<Models> GetEmp(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEmp()
        {
            throw new NotImplementedException();
        }
    }
}
