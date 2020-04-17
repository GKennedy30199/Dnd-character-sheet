namespace Dnd_character_sheet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassesID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        HitDice = c.Int(nullable: false),
                        FirstLevelHP = c.Int(nullable: false),
                        SavingThrow1 = c.String(),
                        SavingThrow2 = c.String(),
                        Skill1 = c.String(),
                        Skill2 = c.String(),
                        Skill3 = c.String(),
                        Skill4 = c.String(),
                        Skill5 = c.String(),
                        Skill6 = c.String(),
                        Race_RaceID = c.Int(),
                    })
                .PrimaryKey(t => t.ClassesID)
                .ForeignKey("dbo.Races", t => t.Race_RaceID)
                .Index(t => t.Race_RaceID);
            
            CreateTable(
                "dbo.Feats",
                c => new
                    {
                        FeatID = c.Int(nullable: false, identity: true),
                        ClassID = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Classes_ClassesID = c.Int(),
                    })
                .PrimaryKey(t => t.FeatID)
                .ForeignKey("dbo.Classes", t => t.Classes_ClassesID)
                .Index(t => t.Classes_ClassesID);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        RaceID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AbilityScore = c.Int(nullable: false),
                        Alignment = c.String(),
                        Size = c.String(),
                        Speed = c.Int(nullable: false),
                        Languages = c.String(),
                    })
                .PrimaryKey(t => t.RaceID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "Race_RaceID", "dbo.Races");
            DropForeignKey("dbo.Feats", "Classes_ClassesID", "dbo.Classes");
            DropIndex("dbo.Feats", new[] { "Classes_ClassesID" });
            DropIndex("dbo.Classes", new[] { "Race_RaceID" });
            DropTable("dbo.Races");
            DropTable("dbo.Feats");
            DropTable("dbo.Classes");
        }
    }
}
