using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Models;
using VotingApp.Repository;

namespace VotingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private ICandidateRepository _candidateRepository;
        public CandidateController(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCandidate(int id)
        {
            return Ok(_candidateRepository.GetCandidate(id));
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetCandidates()
        {
            var candidates = _candidateRepository.GelAllCandidates();
            var mapped = candidates.Select(x => new CandidateSummary
            {
                Id = x.Id,
                Name = x.Name,
                Votes = x.VoterList?.Count ?? 0
            });

            return Ok(mapped);
        }
        [HttpPost]
        [Route("Add")]
        public void AddCandidate(Candidate candidate)
        {
           _candidateRepository.AddCandidate(candidate);
        }
    }
}
