using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Models
{
    public class Voter
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Candidate Candidate { get; set; }
    }
}
