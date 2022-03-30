using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS_Intens.Models;

namespace HRMS_Intens.Interfaces
{
    public interface IJobCandidateRepository
    {
        IQueryable<JobCandidate> GetAll();

        void Update(JobCandidate candidate);

        void Delete(JobCandidate candidate);

        JobCandidate GetById(int id);

        void Add(JobCandidate candidate);

    }
}
