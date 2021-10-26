namespace NVC1521050560.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class1",
                c => new
                    {
                        class4 = c.String(nullable: false, maxLength: 128),
                        class2 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.class4);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(),
                        University = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Person", t => t.PersonID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Lecture",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        LectureID = c.String(),
                        Faculty = c.String(nullable: false),
                        Department = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Person", t => t.PersonID)
                .Index(t => t.PersonID);
            
            DropTable("dbo.Person");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            DropForeignKey("dbo.Lecture", "PersonID", "dbo.Person");
            DropForeignKey("dbo.Student", "PersonID", "dbo.Person");
            DropIndex("dbo.Lecture", new[] { "PersonID" });
            DropIndex("dbo.Student", new[] { "PersonID" });
            DropTable("dbo.Lecture");
            DropTable("dbo.Student");
            DropTable("dbo.Person");
            DropTable("dbo.Class1");
        }
    }}
