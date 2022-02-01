using System.ComponentModel.DataAnnotations.Schema;

namespace VotingApp.Models
{
    public class VoterCandidate
    {
        public Voter voter;
        public Candidate candidate;
        public VoterCandidate()
        {
            voter = new Voter();
            candidate = new Candidate();
        }
        [ForeignKey("VoterId")]
        public int VoterId { get; set; }
        [ForeignKey("CandidateId")]
        public int CandidateId { get; set; }
    }
}
