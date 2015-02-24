using Sopo.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Repository {
	public class SopoContext : DbContext {
		public SopoContext()
			: base("SopoDB") {
			Database.SetInitializer<SopoContext>(new CreateDatabaseIfNotExists<SopoContext>());
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Log> Logs { get; set; }

		// public DbSet<Friend> Friends { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>().HasMany(x => x.Friend).WithMany();
		}
	}
}
