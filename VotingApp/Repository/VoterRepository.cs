using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingApp.Models;

namespace VotingApp.Repository
{
    public class VoterRepository : IVoterRepository

    {
        private AppDbContext context { get; }
        public VoterRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddVoter(Voter voter)
        {
            context.Voters.Add(voter);
            context.SaveChanges();
        }

        public IEnumerable<Voter> GelAllVoters()
        {
            return context.Voters;
        }

        public Voter GetVoter(int id)
        {
            Voter voter = context.Voters.Find(id);
            return voter;
        }
    }
}
