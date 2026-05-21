using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace S00266759OODMayExam2026
{
    public class ClubData : DbContext
    {
        public ClubData() : base("OODExam_HannahRodtmann")
        {
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configuring one to many relationship
            modelBuilder.Entity<TrainingSession>()
                .HasRequired(ts => ts.Member)
                .WithMany(m => m.TrainingSessions)
                .HasForeignKey(ts => ts.MemberId);
        }
    }
}
