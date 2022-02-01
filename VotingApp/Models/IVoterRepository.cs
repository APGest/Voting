using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Models
{
    public interface IVoterRepository
    {
        Voter GetVoter(int id);
        IEnumerable<Voter> GelAllVoters();
        void AddVoter(Voter voter);
    }
}
