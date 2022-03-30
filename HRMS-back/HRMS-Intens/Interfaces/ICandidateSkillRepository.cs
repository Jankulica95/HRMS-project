using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS_Intens.Models;

namespace HRMS_Intens.Interfaces
{
    public interface ICandidateSkillRepository
    {
        IQueryable<CandidateSkill> GetAll();

        void Delete(CandidateSkill skill);

        void Add(CandidateSkill skill);

        CandidateSkill GetById(int id);

    }
}
