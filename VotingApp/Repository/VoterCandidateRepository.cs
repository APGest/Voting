using System.Collections.Generic;
using VotingApp.Models;

namespace VotingApp.Repository
{
    public class VoterCandidateRepository : IVoterCandidateRepository

    {
        private AppDbContext _context { get; }
        public VoterCandidateRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Vote(VoterCandidate voterCandidate)
        {
          _context.Add(voterCandidate);
        }

        public IEnumerable<VoterCandidate> GetAll()
        {
            return _context.VoterCandidates;
        }
    }
}
