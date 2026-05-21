namespace S00266759OODMayExam2026.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        ContactNumber = c.String(),
                        MembershipType = c.String(),
                    })
                .PrimaryKey(t => t.MemberID);
            
            CreateTable(
                "dbo.TrainingSessions",
                c => new
                    {
                        TrainingSessionId = c.Int(nullable: false, identity: true),
                        SessionDate = c.DateTime(nullable: false),
                        SessionType = c.String(),
                        DurationMinutes = c.Int(nullable: false),
                        CoachNotes = c.String(),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrainingSessionId)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingSessions", "MemberId", "dbo.Members");
            DropIndex("dbo.TrainingSessions", new[] { "MemberId" });
            DropTable("dbo.TrainingSessions");
            DropTable("dbo.Members");
        }
    }
}
