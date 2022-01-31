using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Models
{
    public interface ICandidateRepository
    {    
        Candidate GetCandidate(int id);
        IEnumerable<Candidate> GelAllCandidates();
        void AddCandidate(Candidate candidate);
    }
}
