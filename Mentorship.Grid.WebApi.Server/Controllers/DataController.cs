using Mentorship.Grid.DataAccess.Models;
using System.Collections.Generic;
using System.Web.Http;
using Mentorship.Grid.DataAccess.Interfaces;

namespace Mentorship.Grid.WebApi.Server.Controllers
{
    public class DataController : ApiController
    {
        private IRepository<Billionaire> _repository;

        public DataController(IRepository<Billionaire> repo)
        {
            _repository = repo;
        }

        public IEnumerable<Billionaire> GetAll()
        {
            var result = _repository.GetAll(); 
            
            return result;
        }

        // GET: api/Data/5
        //[ResponseType(typeof(Billionaire))]
        public IHttpActionResult GetBillionaire(int id)
        {
            Billionaire billionaire = _repository.Get(id);
            if (billionaire == null)
            {
                return NotFound();
            }

            return Ok(billionaire);
        }
    }
}
