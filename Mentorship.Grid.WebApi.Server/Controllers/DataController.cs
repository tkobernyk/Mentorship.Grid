using Mentorship.Grid.DataAccess.Context;
using Mentorship.Grid.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;

namespace Mentorship.Grid.WebApi.Server.Controllers
{
    public class DataController : ApiController
    {
        private BillionairesDbContext db = new BillionairesDbContext();

        public IEnumerable<Billionaire> GetAll()
        {
            var result = db.Billionaires.Include(b => b.SourcesOfWealth).ToList();
            
            return result;
        }

        // GET: api/Data/5
        //[ResponseType(typeof(Billionaire))]
        public IHttpActionResult GetBillionaire(int id)
        {
            Billionaire billionaire = db.Billionaires.Include(b => b.SourcesOfWealth).ToList().Find(b => b.Id == id);
            if (billionaire == null)
            {
                return NotFound();
            }

            return Ok(billionaire);
        }
    }
}
