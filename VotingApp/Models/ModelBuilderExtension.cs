using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingApp.Models
{
    public static class ModelBuilderExtension
    {
        public static void SeedCandidate(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Candidate>().HasData(new Candidate
            //{
            //    VoterList = new List<Voter>(),
            //    Id = 1,
            //    Name = "PiotrusPan",
            //});
            //modelBuilder.Entity<Candidate>().HasData(new Candidate
            //{
            //    VoterList = new List<Voter>(),
            //    Id = 2,
            //    Name = "Pumba",
            //});
        }
        public static void SeedVoter(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Voter>().HasData(new Voter
            //{
            //    Candidate = new Candidate(),
            //    Id = 1,
            //    Name = "Andrzej",
            //});
            //modelBuilder.Entity<Voter>().HasData(new Voter
            //{
            //    Candidate = new Candidate(),
            //    Id = 2,
            //    Name = "Jurek",
            //});
        }
        public static void SeedVoterCandidate(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Candidate>().HasMany(v => v.VoterList).WithOne(c => c.Candidate);
            //modelBuilder.Entity<VoterCandidate>().HasData(new VoterCandidate
            //{
            //    VoterId = 1,
            //    CandidateId = 1,
            //});
            //modelBuilder.Entity<VoterCandidate>().HasData(new VoterCandidate
            //{
            //    VoterId = 1,
            //    CandidateId = 2,
            //});
        }
    }
}
