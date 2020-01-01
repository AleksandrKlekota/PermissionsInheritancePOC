using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PermissionsInheritancePOC.DAL
{
    public class Procedures
    {
        public static List<string> GetNames(int securityObjectId)
        {
            List<string> final = new List<string>();
            using (var context = new CompanyDepartmentEmployeeEntities())
            {
                var unitsWithPermission = context.getNamesWithPermissions(securityObjectId);
                foreach (var str in unitsWithPermission)
                {
                    final.Add(str);
                }
            }
            return(final);
        }
        public static List<string> GetSecurityObjects(string name)
        {
            List<string> final = new List<string>();
            using (var context = new CompanyDepartmentEmployeeEntities())
            {
                var objects = context.getSecurityObjectByName(name);
                foreach (var str in objects)
                {
                    final.Add(str);
                }
            }
            return (final);
        }
        public static List<string> GetAllUnits()
        {
            List <string> final = new List<string>();
            using (var context = new CompanyDepartmentEmployeeEntities())
            {
                var units = context.CreateUnitTable();
                foreach (var str in units)
                {
                    final.Add(str);
                }
            }
            return (final);
        }
    }
}
