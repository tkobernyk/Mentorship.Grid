using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Mentorship.Grid.DataAccess.Context;
using Mentorship.Grid.DataAccess.Models;

namespace Mentorship.Grid.WebApi.Server.Controllers
{
    public class edgf
    {
        //private BillionairesDbContext db = new BillionairesDbContext();

        //// GET: api/Data
        //public IQueryable<Billionaire> GetBillionaires()
        //{
        //    return db.Billionaires;
        //}

        //// GET: api/Data/5
        //[ResponseType(typeof(Billionaire))]
        //public IHttpActionResult GetBillionaire(int id)
        //{
        //    Billionaire billionaire = db.Billionaires.Find(id);
        //    if (billionaire == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(billionaire);
        //}

        //// PUT: api/Data/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutBillionaire(int id, Billionaire billionaire)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != billionaire.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(billionaire).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BillionaireExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Data
        //[ResponseType(typeof(Billionaire))]
        //public IHttpActionResult PostBillionaire(Billionaire billionaire)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Billionaires.Add(billionaire);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = billionaire.Id }, billionaire);
        //}

        //// DELETE: api/Data/5
        //[ResponseType(typeof(Billionaire))]
        //public IHttpActionResult DeleteBillionaire(int id)
        //{
        //    Billionaire billionaire = db.Billionaires.Find(id);
        //    if (billionaire == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Billionaires.Remove(billionaire);
        //    db.SaveChanges();

        //    return Ok(billionaire);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool BillionaireExists(int id)
        //{
        //    return db.Billionaires.Count(e => e.Id == id) > 0;
        //}
    }
}