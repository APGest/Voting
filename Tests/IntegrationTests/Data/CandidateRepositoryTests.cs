using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using VotingApp.Models;
using VotingApp.Repository;
using Xunit;

namespace Tests.IntegrationTests.Data
{
    public class CandidateRepositoryTests
    {
        private readonly AppDbContext _context;

        public CandidateRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().UseSqlServer("Server=192.168.2.150,1433;Database=Voting;User Id=brzooz;Password=Password12345#;").Options;

            _context = new AppDbContext(options);
        }

        [Fact]
        public void AddTest()
        {
            var repository = new CandidateRepository(_context);

            var guid = new Guid().ToString();

            var candidate = new Candidate
            {
                Name = guid
            };

            repository.AddCandidate(candidate);

            var actualCandidate = _context.Candidates.FirstOrDefaultAsync(x => x.Name == guid);

            Assert.NotNull(actualCandidate);
        }

        [Fact]
        public void GetAllTest()
        {
            var allCandidates = _context.Candidates.ToList();

            var repository = new CandidateRepository(_context);

            var actualCandidates = repository.GelAllCandidates();

            Assert.Equal(allCandidates.Count, actualCandidates.Count());
        }
    }
}