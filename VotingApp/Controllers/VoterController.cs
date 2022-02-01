using Microsoft.AspNetCore.Mvc;
using VotingApp.Models;
using VotingApp.Repository;

namespace VotingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoterController : ControllerBase
    {
        private IVoterRepository _voterRepository;
        public VoterController(IVoterRepository voterRepository)
        {
            _voterRepository = voterRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCandidate(int id)
        {
            return Ok(_voterRepository.GetVoter(id));
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetVoters()
        {
            return Ok(_voterRepository.GelAllVoters());
        }
        [HttpPost]
        [Route("Add")]
        public void AddVoter(Voter voter)
        {
            _voterRepository.AddVoter(voter);
        }
    }
}
