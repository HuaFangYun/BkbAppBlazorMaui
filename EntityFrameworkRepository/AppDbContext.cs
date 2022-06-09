using EntityFrameworkRepository.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EntityFrameworkRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNull] DbContextOptions options) : base(options) { }

        public virtual DbSet<EventEntityModel> Events { get; set; }
        public virtual DbSet<GroupEntityModel> Groups { get; set; }
        public virtual DbSet<GroupMemberEntityModel> GroupMembers { get; set; }
        public virtual DbSet<ParticipationEntityModel> Participations { get; set; }
        public virtual DbSet<UserEntityModel> Users { get; set; }
    }
}
