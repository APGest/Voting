using VotingApp.Extensions;
using VotingApp.Models;
using Xunit;

namespace Tests.UnitTests
{
    public class VoterExtensionsTests
    {
        [Fact]
        public void MappingTest()
        {
            var voter = new Voter
            {
                Id = 1,
                Name = "test",
                Candidate = null
            };

            var actualVoterSummary = voter.ToVoterSummary();

            Assert.Equal(1, actualVoterSummary.Id);
            Assert.Equal("test", actualVoterSummary.Name);
            Assert.False(actualVoterSummary.HasVoted);
        }
    }
}