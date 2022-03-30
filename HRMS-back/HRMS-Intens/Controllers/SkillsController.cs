using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS_Intens.Models;
using HRMS_Intens.Interfaces;

namespace HRMS_Intens.Controllers
{
    public class SkillsController : ApiController
    {
        ICandidateSkillRepository _repository { get; set; }

        public SkillsController (ICandidateSkillRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<CandidateSkill> Get()
        {
            return _repository.GetAll();
        }

        public IHttpActionResult Post(CandidateSkill skill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.Add(skill);
            return CreatedAtRoute("DefaultApi", new { id = skill.Id }, skill);
        }

        public IHttpActionResult Delete(int id)
        {
            var skill = _repository.GetById(id);
            if(skill == null)
            {
                return NotFound();
            }

            _repository.Delete(skill);
            return Ok();
        }



    }
}
