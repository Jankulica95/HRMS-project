using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS_Intens.Models
{
    public class CandidateSkill
    {

        public CandidateSkill()
        {
            this.JobCandidates = new HashSet<JobCandidate>();
        }

        public int Id { get; set; }

        public string SkillName { get; set; }

        public virtual ICollection<JobCandidate> JobCandidates { get; set; }

    }
}