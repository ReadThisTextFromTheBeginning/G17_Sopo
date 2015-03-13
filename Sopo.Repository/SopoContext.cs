using Sopo.Repository;
using Sopo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository
{
    public class SopoContext : DbContext
    {
        public SopoContext()
            : base("SopoDB")
        {
            Database.SetInitializer<SopoContext>(new DropCreateDatabaseIfModelChanges<SopoContext>()); //!Notice That It is chosen DropCreateAlways Ctor!
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<Rating> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<CountryRepository> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasMany<Message>(x => x.SentMessages).WithRequired(x => x.Sender);
            modelBuilder.Entity<User>().HasMany<Message>(x => x.ReceivedMessages).WithRequired(x => x.Receiver);

            modelBuilder.Entity<User>().HasMany<Group>(x => x.Groups).WithMany(x => x.Users);

            modelBuilder.Entity<User>().HasMany<Relationship>(x => x.SentRelationships).WithRequired(x => x.ActionUser);
            modelBuilder.Entity<User>().HasMany<Relationship>(x => x.ReceivedRelationships).WithRequired(x => x.OtherUser);

            modelBuilder.Entity<Picture>().HasMany<Post>(x => x.Posts).WithMany(x => x.Images);

            modelBuilder.Entity<User>().HasOptional<Profile>(x => x.Profile).WithRequired(x => x.User);
        }
    }
}
