using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Extensions;
using VotingApp.Models;
using VotingApp.Repository;

namespace VotingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoterController : ControllerBase
    {
        private IVoterRepository _voterRepository;
        private readonly ICandidateRepository _candidateRepository;

        public VoterController(IVoterRepository voterRepository, ICandidateRepository candidateRepository)
        {
            _voterRepository = voterRepository;
            _candidateRepository = candidateRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetVoter(int id)
        {
            return Ok(_voterRepository.GetVoter(id));
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetVoters()
        {
            var voters = _voterRepository.GelAllVoters();
            var mapped = voters.Select(x => x.ToVoterSummary());

            return Ok(mapped);
        }
        [HttpPost]
        [Route("Add")]
        public void AddVoter(Voter voter)
        {
            _voterRepository.AddVoter(voter);
        }

        [HttpPost("{voterId}/vote")]
        public IActionResult Vote(int voterId, [FromBody] int candidateId)
        {
            var voter = _voterRepository.GetVoter(voterId);
            var candidate = _candidateRepository.GetCandidate(candidateId);
            voter.Candidate = candidate;
            _voterRepository.Update(voter);

            return Ok();
        }
    }
}
