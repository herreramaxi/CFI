namespace CFI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkillsTableIsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplicationUserSkills",
                c => new
                    {
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                        Skills_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ApplicationUser_Id, t.Skills_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skills_Id, cascadeDelete: true)
                .Index(t => t.ApplicationUser_Id)
                .Index(t => t.Skills_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserSkills", "Skills_Id", "dbo.Skills");
            DropForeignKey("dbo.ApplicationUserSkills", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ApplicationUserSkills", new[] { "Skills_Id" });
            DropIndex("dbo.ApplicationUserSkills", new[] { "ApplicationUser_Id" });
            DropTable("dbo.ApplicationUserSkills");
            DropTable("dbo.Skills");
        }
    }
}
