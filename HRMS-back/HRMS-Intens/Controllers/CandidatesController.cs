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
    public class CandidatesController : ApiController
    {
        IJobCandidateRepository _repository { get; set; }

        public CandidatesController(IJobCandidateRepository repository)
        {
            _repository = repository;
        }



        public IQueryable<JobCandidate> Get()
        {
            return _repository.GetAll();
        }

        public IHttpActionResult Delete(int id)
        {
            var candidate = _repository.GetById(id);
            if (candidate == null)
            {
                return NotFound();
            }

            _repository.Delete(candidate);
            return Ok();

        }

        public IHttpActionResult Put (int id, JobCandidate candidate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != candidate.Id)
            {
                return BadRequest();
            }

            try
            {
                _repository.Update(candidate);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(candidate);

        }

        public IHttpActionResult Post (JobCandidate candidate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.Add(candidate);
            return CreatedAtRoute("DefaultApi", new { id = candidate.Id }, candidate);
        }


    }
}
