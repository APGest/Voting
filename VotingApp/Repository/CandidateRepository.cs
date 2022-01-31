using System.Collections.Generic;
using VotingApp.Models;

namespace VotingApp.Repository
{
    public class CandidateRepository : ICandidateRepository

    {
        private AppDbContext context { get; }
        public CandidateRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddCandidate(Candidate candidate)
        {
            context.Candidates.Add(candidate);
            context.SaveChanges();
        }

        public IEnumerable<Candidate> GelAllCandidates()
        {
            return context.Candidates;
        }

        public Candidate GetCandidate(int id)
        {
            Candidate candidate = context.Candidates.Find(id);
            return candidate;
        }
    }
}
