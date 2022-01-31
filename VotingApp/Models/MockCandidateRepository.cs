﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Models
{
    public class MockCandidateRepository : ICandidateRepository
    {
        private List<Candidate> _candidates;
        public void AddCandidate(Candidate candidate)
        {
            candidate.Id = _candidates.Max(c => c.Id) + 1;
            _candidates.Add(candidate);
        }

        public IEnumerable<Candidate> GelAllCandidates()
        {
            return _candidates;
        }

        public Candidate GetCandidate(int id)
        {
            return _candidates.FirstOrDefault(c => c.Id == id);
        }
    }
}
