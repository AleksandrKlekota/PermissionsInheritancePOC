using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermissionsInheritancePOC.Models
{
    public class Identity
    {
        public int Id { get; set; }
        public int ParrentId { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
    }
}