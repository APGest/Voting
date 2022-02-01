﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VotingApp.Models;

namespace VotingApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VotingApp.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "PiotrusPan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pumba"
                        });
                });

            modelBuilder.Entity("VotingApp.Models.Voter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Voters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Andrzej"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jurek"
                        });
                });

            modelBuilder.Entity("VotingApp.Models.VoterCandidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("VoterId")
                        .HasColumnType("int");

                    b.HasKey("CandidateId", "VoterId");

                    b.ToTable("VoterCandidates");

                    b.HasData(
                        new
                        {
                            CandidateId = 1,
                            VoterId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}