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
            IList<string> final = null;
            final = Procedures.GetNames(securityObjectId);
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
        public IHttpActionResult GetSecurityObjects(string name)
        {
            IList<string> final = null;
            final = Procedures.GetSecurityObjects(name);
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
        public IHttpActionResult GetAllUnits()
        {
            IList<string> final = null;
            final = Procedures.GetAllUnits();
            if (final == null)
            {
                return NotFound();
            }
            return Ok(final);
        }
    }
}
