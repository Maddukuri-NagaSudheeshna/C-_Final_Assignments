using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSForLitwareOrganization
{
    internal class LitwareLib : IPrintable
    {

        public void LoginForLitwareOrg() 
        {
            Console.WriteLine("Please Login Using EmployeeId and EmployeeName");
        }
        public void LogoutfromLitwareOrg() 
        {
            Console.WriteLine("your LoginSession Expired");
        }

        static void Main(string[] args)
        {
            LitwareLib lit = new LitwareLib();
            lit.LoginForLitwareOrg();
            int TotalEmployeeCount = 10;
            for(int i=1;i<=TotalEmployeeCount;i++)
            {
                Employee emp = new Employee();
                emp.Method1(101);
                emp.Method2("kishan kumar");
                emp.Method3();
            }
            lit.LogoutfromLitwareOrg();

            /*emp.Method1(101);
            emp.Method2("Sudheeshna");
            emp.Method3(); */   


            //emp.MethodforHRA();
            //emp.MethodForGrossSalary();
            //emp.CalculateSalary();
        }
       
    }
}
