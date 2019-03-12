using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessRepo;
using ActualDataBaseRepo;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice:\n1.DataBase \t2.Static Database");
            int n = Convert.ToInt32(Console.ReadLine());
            int ch=0;
            if (n == 1)
            {
                ch = 1;
            }
            if(n==2)
            {
                ch = 2;
            }
            EmployeeBLRepo blrepo = new EmployeeBLRepo(ch);
            Employee emp = new Employee();
            var list1= blrepo.GetAllEmp();
            // var list2 = blrepo.GetEmp(6);
            //blrepo.SaveEmp();
            Console.WriteLine("-----Employee Details----");
            foreach (var it in list1)
            {
                Console.WriteLine(it.Id+" "+ it.Name+" "+it.salary);
            }
            Console.ReadLine();
        }
    }
}
