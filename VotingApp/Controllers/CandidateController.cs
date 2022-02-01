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
            return Ok(_candidateRepository.GelAllCandidates());
        }
        [HttpPost]
        [Route("Add")]
        public void AddCandidate(Candidate candidate)
        {
           _candidateRepository.AddCandidate(candidate);
        }
    }
}
