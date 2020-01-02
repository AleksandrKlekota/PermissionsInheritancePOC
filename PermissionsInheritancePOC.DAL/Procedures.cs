using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PermissionsInheritancePOC.DAL
{
    public class Procedures
    {
        public static List<PermissionsInheritancePOC.DAL.getNamesWithPermissions_Result> GetNames(int securityObjectId)
        {
            List<PermissionsInheritancePOC.DAL.getNamesWithPermissions_Result> final
                = new List<PermissionsInheritancePOC.DAL.getNamesWithPermissions_Result>();
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
        public static List<PermissionsInheritancePOC.DAL.getSecurityObjectByName_Result> GetSecurityObjects(string name)
        {
            List<PermissionsInheritancePOC.DAL.getSecurityObjectByName_Result> final 
                = new List<PermissionsInheritancePOC.DAL.getSecurityObjectByName_Result>();
             
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
        public static List<PermissionsInheritancePOC.DAL.CreateUnitTable_Result> GetUnitsList()
        {
            List <PermissionsInheritancePOC.DAL.CreateUnitTable_Result> final 
                = new List<PermissionsInheritancePOC.DAL.CreateUnitTable_Result>();

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
        public static List<PermissionsInheritancePOC.DAL.getSecurityObjectsList_Result> GetSecurityObjectsList()
        {
            List<PermissionsInheritancePOC.DAL.getSecurityObjectsList_Result> final
                = new List<PermissionsInheritancePOC.DAL.getSecurityObjectsList_Result>();

            using (var context = new CompanyDepartmentEmployeeEntities())
            {
                var units = context.getSecurityObjectsList();
                foreach (var str in units)
                {
                    final.Add(str);
                }
            }
            return (final);
        }
    }
}
