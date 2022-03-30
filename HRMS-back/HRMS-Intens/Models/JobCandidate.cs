using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMS_Intens.Models
{
    public class JobCandidate
    {

         public JobCandidate()
        {
            this.CandidateSkills = new HashSet<CandidateSkill>();
        }


        public int Id { get; set; }

        public string FullName { get; set; }

        public string DateOfBirth { get; set; }

        public string ContactNum { get; set; }

        public string Email { get; set; }

        
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; }




    }
}