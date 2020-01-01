using PermissionsInheritancePOC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionsInheritancePOC.Test
{
    static class Program
    {
        static void Main(string[] args)
        {/*
            using (var context = new CompanyDepartmentEmployeeEntities())
            {
                string name = "Alice";
                var so = context.getSecurityObjectByName(name);
                
                foreach (var student in so)
                {
                    Console.WriteLine("Sec. Object {0}",
                       student);
                }
                int id = 1;
                var nwp = context.getNamesWithPermissions(id);
                Console.WriteLine("");
                Console.WriteLine("NEXT PROC");
                Console.WriteLine("");
                foreach (var student in nwp)
                {
                    Console.WriteLine("Name {0}",
                       student);
                }
                Console.ReadKey();
            }
          
            string[] str = new string[100];
                str = GetAllUnits();
            for (int i =0 )*/

        }
                public static string[] GetAllUnits()
        {
            string[] final = new string[100];
            using (var context = new CompanyDepartmentEmployeeEntities())
            {
                var units = context.CreateUnitTable();
                var i = 0;
                foreach (var str in units)
                {
                    final[i] = str;
                    i++;
                }
            }
            return (final);
        }
    }
}
