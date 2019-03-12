using CustomModels;
using IDatabaseRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActualDataBaseRepo;

namespace DataBaseRepo
{

    public class EmployeeRepo : IDatabaseRepo.IEmployeeRepo
    {
       
        public IEnumerable<Models> GetAllEmp()
        {
            IList<Models> em = new List<Models>();
            Models[] EmArray = {
                new Models() {  Id=1, Name ="John",salary = 10000 },
                new Models() { Id=2, Name ="John",salary = 10000 },
                new Models() { Id=3, Name ="John",salary = 10000},
                new Models() { Id=4, Name ="John",salary = 10000 },
                new Models() { Id=5, Name ="John",salary = 10000 },
                new Models() {  Id=5, Name ="John",salary = 10000 },
                new Models() { Id=6, Name ="John",salary = 10000  },
            };
            return EmArray;
        }
        public IEnumerable<Models> GetEmp(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEmp()
        {
            throw new NotImplementedException();
        }
   
    public class Emplist
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
    }


    //public IEnumerable<empl> GetAllEmp()
    //    {
    //        IEnumerable<empl> em;
    //        em = db.empls.ToList();
    //        return em;
    //    }

    //    public IEnumerable<empl> GetEmp(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveEmp()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}
