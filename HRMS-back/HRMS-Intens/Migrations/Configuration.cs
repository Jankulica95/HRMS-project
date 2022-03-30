namespace HRMS_Intens.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HRMS_Intens.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HRMS_Intens.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HRMS_Intens.Models.ApplicationDbContext context)
        {

            var Candidate01 = new JobCandidate { Id = 1, FullName = "Stefan Petrovic", DateOfBirth = "14.06.1997.", ContactNum = "062444555", Email = "candidate01@gamil.com", CandidateSkills = new List<CandidateSkill>() };
            var Candidate02 = new JobCandidate { Id = 2, FullName = "Petar Stefanovic", DateOfBirth = "24.08.1996.", ContactNum = "063555333", Email = "candidate02@gamil.com", CandidateSkills = new List<CandidateSkill>() };
            var Candidate03 = new JobCandidate { Id = 3, FullName = "Miljana Stankovic", DateOfBirth = "23.06.1999.", ContactNum = "062544855", Email = "candidate03@gamil.com", CandidateSkills = new List<CandidateSkill>() };
            var Candidate04 = new JobCandidate { Id = 4, FullName = "Ratko Jankovic", DateOfBirth = "22.05.1995.", ContactNum = "061446575", Email = "candidate04@gamil.com", CandidateSkills = new List<CandidateSkill>() };


            var Skill01 = new CandidateSkill { Id = 1, SkillName = "C#" };
            var Skill02 = new CandidateSkill { Id = 2, SkillName = "F#" };
            var Skill03 = new CandidateSkill { Id = 3, SkillName = "Java" };
            var Skill04 = new CandidateSkill { Id = 4, SkillName = "JavaScript" };
            var Skill05 = new CandidateSkill { Id = 5, SkillName = "React" };
            var Skill06 = new CandidateSkill { Id = 6, SkillName = "Vue" };
            var Skill07 = new CandidateSkill { Id = 7, SkillName = "C++" };
            var Skill08 = new CandidateSkill { Id = 8, SkillName = "Python" };


            Candidate01.CandidateSkills.Add(Skill01);
            Candidate01.CandidateSkills.Add(Skill05);
            Candidate01.CandidateSkills.Add(Skill06);

            Candidate02.CandidateSkills.Add(Skill08);
            Candidate02.CandidateSkills.Add(Skill01);

            Candidate03.CandidateSkills.Add(Skill06);
            Candidate03.CandidateSkills.Add(Skill02);

            Candidate04.CandidateSkills.Add(Skill05);
            Candidate04.CandidateSkills.Add(Skill07);


            context.Candidates.Add(Candidate01);
            context.Candidates.Add(Candidate02);
            context.Candidates.Add(Candidate03);
            context.Candidates.Add(Candidate04);



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
