using PermissionsInheritancePOC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PermissionsInheritancePOC.Controllers
{
    public class PermissionsController : ApiController
    {
        public PermissionsController()
            {
            }
        public IHttpActionResult GetNamesWithPermissions(int securityObjectId)
        {
            IList<PermissionsInheritancePOC.DAL.getNamesWithPermissions_Result> final = null;
            final = Procedures.GetNames(securityObjectId);
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
        public IHttpActionResult GetAllSecurityObjects()
        {
            IList<PermissionsInheritancePOC.DAL.getSecurityObjectsList_Result> final = null;
            final = Procedures.GetSecurityObjectsList();
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
    }
    public class UnitsController : ApiController
    {
        public IHttpActionResult GetAllUnits()
        {
            IList<PermissionsInheritancePOC.DAL.CreateUnitTable_Result> final = null;
            final = Procedures.GetUnitsList();
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
        public IHttpActionResult GetSecurityObjects(string name)
        {
            IList<PermissionsInheritancePOC.DAL.getSecurityObjectByName_Result> final = null;
            final = Procedures.GetSecurityObjects(name);
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
    }
}
