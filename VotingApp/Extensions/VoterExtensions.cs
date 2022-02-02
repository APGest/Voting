using VotingApp.Models;

namespace VotingApp.Extensions
{
    public static class VoterExtensions
    {
        public static VoterSummary ToVoterSummary(this Voter voter)
        {
            return new VoterSummary
            {
                Id = voter.Id,
                Name = voter.Name,
                HasVoted = voter.Candidate != null
            };
        }
    }
}