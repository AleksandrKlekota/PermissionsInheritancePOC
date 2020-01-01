using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PermissionsInheritancePOC.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public int IdentityId { get; set; }
        public int SecurityObjectId { get; set; }
    }
}