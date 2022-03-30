using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRMS_Intens.Models;
using HRMS_Intens.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace HRMS_Intens.Repository
{
    public class JobCandidateRepository : IDisposable, IJobCandidateRepository
    {

        private ApplicationDbContext db = new ApplicationDbContext();


        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IQueryable<JobCandidate> GetAll()
        {
            return db.Candidates;
        }

        public void Update(JobCandidate candidate)
        {
            db.Entry(candidate).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(JobCandidate candidate)
        {
             db.Candidates.Remove(candidate);
            db.SaveChanges();
        }

        public JobCandidate GetById(int id)
        {
            return db.Candidates.FirstOrDefault(p => p.Id == id);
        }

        public void Add(JobCandidate candidate)
        {
            db.Candidates.Add(candidate);
            db.SaveChanges();
        }
    }
}