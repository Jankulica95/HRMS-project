using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRMS_Intens.Models;
using HRMS_Intens.Interfaces;



namespace HRMS_Intens.Repository
{
    public class CandidateSkillRepository : IDisposable, ICandidateSkillRepository
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

        public IQueryable<CandidateSkill> GetAll()
        {
            return db.Skills;
        }

        public void Delete(CandidateSkill skill)
        {
            db.Skills.Remove(skill);
            db.SaveChanges();
        }

        public void Add(CandidateSkill skill)
        {
            db.Skills.Add(skill);
            db.SaveChanges();
        }

        public CandidateSkill GetById(int id)
        {
            return db.Skills.FirstOrDefault(p => p.Id == id);
        }
    }
}